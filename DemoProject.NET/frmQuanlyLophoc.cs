using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject.NET
{
    public partial class frmQuanlyLophoc : Form
    {
        public frmQuanlyLophoc()
        {
            InitializeComponent();
            dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgHienThi.ColumnHeadersHeight = 50;
            dtgHienThi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            dtgHienThi.ColumnHeadersDefaultCellStyle.BackColor = Color.White; // màu vàng
            dtgHienThi.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9);
            dtgHienThi.DefaultCellStyle.ForeColor = Color.Black;
            dtgHienThi.RowTemplate.Height = 60;
            dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.;
            dtgHienThi.DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter };
            dtgHienThi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            buslophoc.Xem(dtgHienThi);

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
        private LopHocBUS bll = new LopHocBUS();

        LopHocBUS buslophoc = new LopHocBUS();
        private void btnXemTL_Click(object sender, EventArgs e)
        {
            buslophoc.Xem(dtgHienThi);
            //List<LopDTO> LopHoc = bll.getLopS();

            //dtgHienThi.DataSource = LopHoc;
        }

        private void frmQuanlyLophoc_Load(object sender, EventArgs e)
        {
            //List<LopDTO> LopHoc = bll.getLopS();
            buslophoc.Xem(dtgHienThi);

            //dtgHienThi.DataSource = LopHoc;
        }
        LopDTO LopSS = new LopDTO();

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text != "" && txtTenLop.Text != "" && txtTrangThai.Text != "" && txtGhiChu.Text != "" )
            {
                LopSS.MaLop = txtMaLop.Text;
                LopSS.TenLop = txtTenLop.Text;
                LopSS.TrangThai = txtTrangThai.Text;
                LopSS.GhiChu = txtGhiChu.Text;
               
                bool result = LopHocBUS.Instance.SuaLopHoc(LopSS);
                if (result)
                {
                    MessageBox.Show("Sửa thông tin lớp học thành công!");

                }
                else
                {
                    MessageBox.Show("Sửa thông tin lớp học thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Nhập Đúng mã lớp học và Không được để trống!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text != "" && txtTenLop.Text != "" && txtTrangThai.Text != "" && txtGhiChu.Text != "")
            {
                LopSS.MaLop = txtMaLop.Text;
                LopSS.TenLop = txtTenLop.Text;
                LopSS.TrangThai = txtTrangThai.Text;
                LopSS.GhiChu = txtGhiChu.Text;
                bool result = LopHocBUS.Instance.ThemLop(LopSS);
                if (result)
                {
                    MessageBox.Show("Thêm lớp học thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm lớp học Thất Bại!");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Nhập Mã lớp học!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string maLop = txtMaLop.Text.Trim();

            // Xác nhận lại việc xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa lớp học có mã " + maLop + "?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Gọi phương thức XoaSoYeuLyLich từ lớp BUS để xóa sơ yếu lý lịch
                if (LopHocBUS.Instance.XoaLopHoc(maLop))
                {
                    MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã lớp học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
