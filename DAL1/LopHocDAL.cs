using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class LopHocDAL
    {
        public static LopHocDAL instance;

        public static LopHocDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LopHocDAL();
                return instance;
            }
        }
        public LopHocDAL() { }

        public List<LopDTO> GetLops()
        {
            List<LopDTO> LopHocS = new List<LopDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                using (SqlCommand command = new SqlCommand("XemDanhSachLop", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maLop = reader.GetString(reader.GetOrdinal("MaLop"));
                            string tenLop = reader.IsDBNull(reader.GetOrdinal("TenLop")) ? null : reader.GetString(reader.GetOrdinal("TenLop"));                          
                            string Trangthai = reader.IsDBNull(reader.GetOrdinal("TrangThai")) ? null : reader.GetString(reader.GetOrdinal("TrangThai"));
                            string GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : reader.GetString(reader.GetOrdinal("GhiChu"));


                            LopDTO lopHoc = new LopDTO(maLop, tenLop, Trangthai, GhiChu);

                            LopHocS.Add(lopHoc);
                        }
                    }
                }
            }

            return LopHocS;
        }

        public bool ThemLop(LopDTO LopHoc)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ thủ tục
                    conn.Open();
                    SqlCommand command = new SqlCommand("ThemLopMoi", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaLop", LopHoc.MaLop);
                    command.Parameters.AddWithValue("@TenLop", LopHoc.TenLop);
                    command.Parameters.AddWithValue("@TrangThai", LopHoc.TrangThai);
                    command.Parameters.AddWithValue("@GhiChu", LopHoc.GhiChu);         
                    int rowsAffected = command.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể chèn dữ liệu!\n" + ex.Message);
                return false;
            }
        }

        public bool XoaLopHoc(string MaLop)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("XoaLop", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaLop", MaLop);
                    int result = command.ExecuteNonQuery();

                    conn.Close();

                    return result > 0;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy mã lớp!");
                return false;
            }
        }

        public bool SuaLop(LopDTO LopHoc)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SuaThongTinLop", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLop", LopHoc.MaLop);
                    cmd.Parameters.AddWithValue("@TenLop", LopHoc.TenLop);
                    cmd.Parameters.AddWithValue("@TrangThai", LopHoc.TrangThai);
                    cmd.Parameters.AddWithValue("@GhiChu", LopHoc.GhiChu);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy mã lớp!");
                return false;
            }
        }
    }
}
