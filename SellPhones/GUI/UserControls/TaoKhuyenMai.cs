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
    public partial class TaoKhuyenMai : Form
    {
        KhuyenMaiUC khuyenMaiUC; // Khai báo biến khuyenMaiUC ở đây

        public TaoKhuyenMai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maCTKM = textBox1.Text;
            string tenCTKM = textBox2.Text;
            // Lấy chuỗi từ comboBox1.Text
            string mucGiamGiaStr = comboBox1.Text;

            // Loại bỏ ký tự '%' từ chuỗi
            mucGiamGiaStr = mucGiamGiaStr.Replace("%", "");

            // Chuyển đổi chuỗi sang kiểu int
            int mucGiamGia = int.Parse(mucGiamGiaStr);
            string loaiSanPham = comboBox2.Text;
            DateTime thoiGianBatDau = dateTimePicker1.Value;
            DateTime thoiGianKetThuc = dateTimePicker2.Value;
            DateTime thoiGianTao = DateTime.Now; // Thời gian tạo hiện tại

            KhuyenMaiBUS.Instance.InsertKhuyenMai(maCTKM, tenCTKM, mucGiamGia, loaiSanPham, thoiGianBatDau, thoiGianKetThuc, thoiGianTao);
            //khuyenMaiUC.loadKhuyenMailist();
            if(thoiGianBatDau > thoiGianKetThuc)
            {

            }
            else resetText();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetText();
        }

        public void resetText()
        {
            textBox1.ResetText();
            textBox2.ResetText();
            comboBox1.ResetText();
            comboBox2.ResetText();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }
    }
}
