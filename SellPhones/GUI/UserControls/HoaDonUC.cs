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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SellPhones.GUI.UserControls
{
    public partial class HoaDonUC : UserControl
    {
        public HoaDonUC()
        {
            InitializeComponent();
            loadflowpanel();
        }


        public void loadflowpanel()
        {
            HoaDonInfo[] hoaDonArray = HoaDonBUS.Instance.GetHoaDonInfoArrayFromDAO();


            if (hoaDonArray != null && hoaDonArray.Length > 0)
            {
                foreach (var hoaDonInfo in hoaDonArray)
                {
                    HoaDonInfoUC hoaDonInfoUC = new HoaDonInfoUC(hoaDonInfo.SoHD, hoaDonInfo.TenKhachHang, hoaDonInfo.NgayXuat, hoaDonInfo.TriGia);

                    // Đăng ký sự kiện Click cho UserControl
                    hoaDonInfoUC.UCClicked += (sender, e) =>
                    {
                        ShowHoaDonDetailForm(hoaDonInfo.SoHD);
                    };

                    flowLayoutPanel1.Controls.Add(hoaDonInfoUC);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu hoá đơn.");
            }
        }

        private void ShowHoaDonDetailForm(string hoaDonID)
        {
            // Mở form chi tiết hoá đơn
            CTHD detailForm = new CTHD(hoaDonID);
            detailForm.HoadonDaXoa += (sender, e) =>
            {
                ReloadFlowPanel(); // Gọi phương thức load lại FlowPanel khi hóa đơn bị xóa
            };
            detailForm.StartPosition = FormStartPosition.CenterParent;
            detailForm.ShowDialog();
        }

        private void ReloadFlowPanel()
        {
            flowLayoutPanel1.Controls.Clear(); // Xóa các UserControl hiện tại
            loadflowpanel(); // Load lại FlowPanel sau khi hóa đơn bị xóa
        }



        private void Taohoadon(string manv)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            TaoHoaDon tao = new TaoHoaDon();
            tao.StartPosition = FormStartPosition.CenterParent;
            tao.getThongTin(); // Gọi phương thức để lấy mã nhân viên
            tao.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear(); // Xóa các UserControl hiện tại
            loadflowpanel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            string searchText = textBox1.Text.Trim();

            if (comboBox1.SelectedIndex == 0) // Tìm theo Mã hóa đơn
            {
                DataTable resultTable = HoaDonBUS.Instance.GetHoaDonByMaHoaDon(searchText);
                DisplaySearchResult(resultTable);
            }
            else if (comboBox1.SelectedIndex == 1) // Tìm theo Họ tên
            {
                DataTable resultTable = HoaDonBUS.Instance.GetHoaDonByHoTen(searchText);
                DisplaySearchResult(resultTable);
            }
        }

        private void DisplaySearchResult(DataTable resultTable)
        {
            flowLayoutPanel1.Controls.Clear();

            if (resultTable != null && resultTable.Rows.Count > 0)
            {
                foreach (DataRow row in resultTable.Rows)
                {
                    HoaDonInfoUC hoaDonInfoUC = new HoaDonInfoUC(
                        row["MaHoaDon"].ToString(),
                        row["TenKH"].ToString(),
                        row["NgayXuat"].ToString(),
                        row["TongGiaSauGiam"].ToString()
                    );

                    // Đăng ký sự kiện Click cho UserControl
                    hoaDonInfoUC.UCClicked += (sender, e) =>
                    {
                        ShowHoaDonDetailForm(row["MaHoaDon"].ToString());
                    };

                    flowLayoutPanel1.Controls.Add(hoaDonInfoUC);
                }
            }
            else
            {

            }
        }

    }

}
