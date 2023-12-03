using SellPhones.BUS;
using SellPhones.DAO;
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
            setNull();
        }

        private void KhachHangUC_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool IsValid(string sdt, string tenKH)
        {

            int parsedSdt;
            if (!int.TryParse(sdt, out parsedSdt) || sdt.Length != 10)
            {
                MessageBox.Show("Số Điện Thoại không hợp lệ. Vui lòng nhập đúng 10 số và không chứa ký tự.");
                return false;
            }



            if (System.Text.RegularExpressions.Regex.IsMatch(tenKH, @"\d"))
            {
                MessageBox.Show("Tên Khách Hàng không hợp lệ. Vui lòng không nhập số.");
                return false;
            }

            return true;
        }

        void setNull()
        {
            //if (comboBox_Type.Items.Count > 0)
            //{
            //    // Chọn item đầu tiên
            //    comboBox_Type.SelectedIndex = 0;
            //}

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
            if (IsValid(phone, name))
            {
                KhachHangBUS.Instance.insertKhachHang(name, address, phone);
                MessageBox.Show("Thêm Thành Công !!!");
                loadKhachHanglist();
            }

        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (Grid_KhachHang.SelectedRows.Count > 0)
            {
                if (IsValid(textBox_Phone.Text, textBox_Name.Text))
                {
                    KhachHangBUS.Instance.UpdateKhachHang(Grid_KhachHang.SelectedRows[0].Cells["MaKH"].Value.ToString(), textBox_Name.Text, textBox_Address.Text, textBox_Phone.Text);
                    MessageBox.Show("Cập nhật thành công !!!");
                    loadKhachHanglist();
                    setNull();
                }

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

        private void button_Search_Click(object sender, EventArgs e)
        {
            //if (comboBox_Type.SelectedIndex.ToString() == "") MessageBox.Show("Vui lòng chọn kiểu dữ liệu để tìm kiếm !!");
            //else
            //{
            //    string action = comboBox_Type.SelectedItem.ToString();
            //    string data = textBox_Search.Text;



            //    DataTable dt = KhachHangDAO.Instance.SearchKH(data);


            //        Grid_KhachHang.DataSource = dt;

            //        Grid_KhachHang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            //        Grid_KhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            //        Grid_KhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            //        Grid_KhachHang.Columns["SDT"].HeaderText = "Số Điện Thoại";
            //        Grid_KhachHang.Columns["MaTK"].HeaderText = "Mã Tài Khoản";



            //        Grid_KhachHang.Columns["MaKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //        Grid_KhachHang.Columns["TenKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //        Grid_KhachHang.Columns["DiaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //        Grid_KhachHang.Columns["SDT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //        Grid_KhachHang.Columns["MaTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //}
            textBox_Search.Text = "";
        }

        private void Grid_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Grid_KhachHang.Rows[e.RowIndex];


                // Hiển thị thông tin từ hàng được chọn lên TextBox
                textBox_MaKH.Text = row.Cells["MaKH"].Value.ToString();
                textBox_Name.Text = row.Cells["TenKH"].Value.ToString();
                textBox_Phone.Text = row.Cells["SDT"].Value.ToString();
                textBox_Address.Text = row.Cells["DiaChi"].Value.ToString();

                // ... thêm các TextBox khác tương ứng với các cột trong DataGridView
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string data = textBox_Search.Text;
            //DataTable dt = KhachHangDAO.Instance.SearchKH(data);


            //Grid_KhachHang.DataSource = dt;

            //Grid_KhachHang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            //Grid_KhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            //Grid_KhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            //Grid_KhachHang.Columns["SDT"].HeaderText = "Số Điện Thoại";
            //Grid_KhachHang.Columns["MaTK"].HeaderText = "Mã Tài Khoản";



            //Grid_KhachHang.Columns["MaKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Grid_KhachHang.Columns["TenKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Grid_KhachHang.Columns["DiaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Grid_KhachHang.Columns["SDT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Grid_KhachHang.Columns["MaTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            string data = textBox_Search.Text;
            DataTable dt = KhachHangDAO.Instance.SearchKH(data);


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
    }
}
