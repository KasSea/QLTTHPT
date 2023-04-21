using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Web.UI.WebControls;

namespace DemoProject.NET
{
    public partial class frmHome : Form
    {
        public GunaButton previousButton = null;

        public frmHome()
        {
            InitializeComponent();
            //btnSoYeuLiLich.PerformClick();
        }

        private Form currentFormchild;
        private void OpenChildForm(Form ChildForm)
        {
            if (currentFormchild != null)
            {
                currentFormchild.Close();
            }
            currentFormchild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock= DockStyle.Fill;
            pnForm.Controls.Add(ChildForm);
            pnForm.Tag = ChildForm;
            
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
            gunaElipsePanel1.Visible = false;
            lblHienThiName.Text = "TiếnAnh";
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //picHome.Visible = true;
           
        }


        
        private void btnTailieu_Click(object sender, EventArgs e)
        {
            //picHome.Visible = true;
            btnMenu.Visible = true;

            if (previousButton != null && previousButton != btnSoYeuLiLich)
            {
                previousButton.BaseColor = Color.FromArgb(52, 58, 64);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnSoYeuLiLich.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnSoYeuLiLich;

            OpenChildForm(new frmSoyeulylich());
            lblHienthi.Text = btnSoYeuLiLich.Text;
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void menuChoice_Opening(object sender, CancelEventArgs e)
        {
         
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
          

        }

        private void menuThem_Click(object sender, EventArgs e)
        {

        }

        private void menuChoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
           

            btnMenu.Visible = true;
            if (previousButton != null && previousButton != btnDiem)
            {
                previousButton.BaseColor = Color.FromArgb(52, 58, 64);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnDiem.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnDiem;
            OpenChildForm(new frmDiemSoHS());
            lblHienthi.Text = btnDiem.Text;
        }

        private void btnHocsinh_Click(object sender, EventArgs e)
        {
           

            btnMenu.Visible = true;

            if (previousButton != null && previousButton != btnHocsinh)
            {
                previousButton.BaseColor = Color.FromArgb(52, 58, 64);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnHocsinh.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnHocsinh;
            OpenChildForm(new frmQuanlyhocsinh());
            lblHienthi.Text = btnHocsinh.Text;
        }

        private void btnGiaovien_Click(object sender, EventArgs e)
        {
         

            btnMenu.Visible = true;
            if (previousButton != null && previousButton != btnGiaovien)
            {
                previousButton.BaseColor = Color.FromArgb(52, 58, 64);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnGiaovien.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnGiaovien;
            OpenChildForm(new frmQuanlyGiaovien());
            lblHienthi.Text = btnGiaovien.Text;
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            

            if (previousButton != null && previousButton != btnLopHoc)
            {
                previousButton.BaseColor = Color.FromArgb(52, 58, 64);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnLopHoc.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnLopHoc;

            OpenChildForm(new frmQuanlyLophoc());
            lblHienthi.Text = btnLopHoc.Text;
        }

        private void btnThoikhoabieu_Click(object sender, EventArgs e)
        {
           

            if (previousButton != null && previousButton != btnThoikhoabieu)
            {
                previousButton.BaseColor = Color.FromArgb(52, 58, 64);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnThoikhoabieu.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnThoikhoabieu;
            OpenChildForm(new frmXemlichHoc());
            lblHienthi.Text = btnThoikhoabieu.Text;

        }

     

        private void gunaButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            btnTk.ContextMenuStrip = menuTK;
            btnTk.ContextMenuStrip.Show(btnTk, new Point(0, btnTk.Height));

        }

        private void menuTK_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void mnstChoice_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
           if (gunaElipsePanel1.Visible == false)
            {
                gunaElipsePanel1.Visible = true;

            }
            else
            {
                gunaElipsePanel1.Visible = false;

            }
        }

        private void gunaControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void dtgHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemTL_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string name = txtTimKiem.Text;
            
           
        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvHienThiTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnMenuchoice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuTK_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_2(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
           

            if (currentFormchild != null)
            {
                currentFormchild.Close();
            }
            lblHienthi.Text = "Home";
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
