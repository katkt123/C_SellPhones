using Microsoft.VisualBasic.ApplicationServices;
using SellPhones.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhones.GUI.UserControls
{
    public partial class TaiKhoanUC : UserControl
    {
        public TaiKhoanUC()
        {
            InitializeComponent();
            loadTaiKhoanlist();
            loadQuyenlist();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string user = textBox_TK.Text;
            string pass = textBox_MK.Text;
            TaiKhoanBUS.Instance.insertTaiKhoan(user, pass);
            loadTaiKhoanlist();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (Grid_TaiKhoan.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa  tài khoản", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string maNV = Grid_TaiKhoan.SelectedRows[0].Cells["MaTK"].Value.ToString();
                    TaiKhoanBUS.Instance.DelTaiKhoan(maNV);
                    Grid_TaiKhoan.Rows.Remove(Grid_TaiKhoan.SelectedRows[0]);
                    setNull();
                }
            }
            else MessageBox.Show("Bạn  phải  chọn  mẩu  tin  cần  xóa");

            loadTaiKhoanlist();
        }

        private void tabPage_TK_Click(object sender, EventArgs e)
        {

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            setNull();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void setNull()
        {
            textBox_TK.Text = "";
            textBox_MK.Text = "";
        }
        public void loadTaiKhoanlist()
        {
            DataTable dt = TaiKhoanBUS.Instance.getAllTaiKhoan();


            Grid_TaiKhoan.DataSource = dt;

            Grid_TaiKhoan.Columns["MaTK"].HeaderText = "Mã Tài Khoản";
            Grid_TaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
            Grid_TaiKhoan.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            Grid_TaiKhoan.Columns["TrangThai"].HeaderText = "Trạng Thái";


            Grid_TaiKhoan.Columns["MaTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_TaiKhoan.Columns["TenDangNhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_TaiKhoan.Columns["MatKhau"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_TaiKhoan.Columns["TrangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        public void loadQuyenlist()
        {
            DataTable dt = TaiKhoanBUS.Instance.getAllQuyen();


            Grid_Quyen.DataSource = dt;

            Grid_Quyen.Columns["MaTK"].HeaderText = "Mã Tài Khoản";
            Grid_Quyen.Columns["PhanQuyen"].HeaderText = "Quyền";



            Grid_Quyen.Columns["MaTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_Quyen.Columns["PhanQuyen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void Grid_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            TaiKhoanBUS.Instance.UpdateTaiKhoan(textBox_TK.Text, textBox_MK.Text);
            loadTaiKhoanlist(); 
        }
    }
}
