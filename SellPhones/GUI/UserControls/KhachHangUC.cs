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
    public partial class KhachHangUC : UserControl
    {
        public KhachHangUC()
        {
            InitializeComponent();
            loadKhachHanglist();
        }

        private void KhachHangUC_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void setNull()
        {
            textBox_Name.Text = "";
            textBox_Address.Text = "";
            textBox_Phone.Text = "";
        }
        public void loadKhachHanglist()
        {
            DataTable dt = KhachHangBUS.Instance.getAllKhachHang();


            Grid_KhachHang.DataSource = dt;

            Grid_KhachHang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            Grid_KhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            Grid_KhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            Grid_KhachHang.Columns["SDT"].HeaderText = "Số Điện Thoại";
            Grid_KhachHang.Columns["MaTK"].HeaderText = "Mã Tài Khoản";



            Grid_KhachHang.Columns["MaKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhachHang.Columns["TenKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhachHang.Columns["DiaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhachHang.Columns["SDT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhachHang.Columns["MaTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            setNull();
            loadKhachHanglist();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string address = textBox_Address.Text;
            string phone = textBox_Phone.Text;
            KhachHangBUS.Instance.insertKhachHang(name, address, phone);
            loadKhachHanglist();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (Grid_KhachHang.SelectedRows.Count > 0)
            {
                KhachHangBUS.Instance.UpdateKhachHang(Grid_KhachHang.SelectedRows[0].Cells["MaKH"].Value.ToString(), textBox_Name.Text, textBox_Address.Text, textBox_Phone.Text);
                loadKhachHanglist();
                setNull();
            }
            else MessageBox.Show("Vui lòng chọn một dòng trước khi sửa !!!!!");
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (Grid_KhachHang.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa  tài khoản", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string maKH = Grid_KhachHang.SelectedRows[0].Cells["MaKH"].Value.ToString();
                    string maTK = Grid_KhachHang.SelectedRows[0].Cells["MaTK"].Value.ToString();
                    KhachHangBUS.Instance.DelKhachHang(maKH, maTK);
                    Grid_KhachHang.Rows.Remove(Grid_KhachHang.SelectedRows[0]);
                    setNull();
                }
            }
            else MessageBox.Show("Vui lòng chọn một dòng trước khi xóa !!!");

            loadKhachHanglist();
        }
    }
}
