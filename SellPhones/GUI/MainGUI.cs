using Microsoft.VisualBasic.Logging;
using SellPhones.GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using SellPhones.DTO;
//using SellPhones.BUS;

namespace SellPhones.GUI
{
    public partial class MainGUI : Form
    {
        private int working = -1;
        private String manvLogined;
        public MainGUI()
        {
            InitializeComponent();
            AddComponent("Tài Khoản", new TaiKhoanUC(), "Logo.png");
            AddComponent("Tài Khoản", new TaiKhoanUC(), "Logo.png");
            AddComponent("Tài Khoản", new TaiKhoanUC(), "Logo.png");
            AddComponent("Tài Khoản", new TaiKhoanUC(), "Logo.png");
            AddComponent("Tài Khoản", new TaiKhoanUC(), "Logo.png");
            AddComponent("Tài Khoản", new TaiKhoanUC(), "Logo.png");
            AddComponent("Tài Khoản", new TaiKhoanUC(), "Logo.png");
            AddComponent("Tài Khoản", new TaiKhoanUC(), "Logo.png");
            AddComponent("Tài Khoản", new TaiKhoanUC(), "Logo.png");
            AddComponent("Tài Khoản", new TaiKhoanUC(), "Logo.png");
            AddComponent("Tài Khoản", new TaiKhoanUC(), "Logo.png");
            SolveEvent();

        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

        }
        private void AddComponent(string buttonName, UserControl userControlname, string path = null)
        {
            int compQuantity = PanelTools.Controls.Count;
            PanelTools.Height = 50 * (compQuantity + 1);

            Button btn = new Button();
            btn.Text = buttonName;
            btn.Size = new Size(200, 50);
            btn.Padding = new Padding(5, 0, 0, 0);
            btn.BackColor = Color.FromArgb(238, 232, 170);
            btn.ForeColor = Color.Black;
            btn.Font = new Font(btn.Font.Name, 14, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Popup;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Image = null;

            if (path != null)
            {

                String imagePath = @"C:\SGU\Nam3 HK1\C#\Doan\SellPhones\SellPhones\Comp\" + path;
                if (System.IO.File.Exists(imagePath))
                {
                    // Tạo hình ảnh từ đường dẫn
                    Image image = Image.FromFile(imagePath);

                    // Đặt hình ảnh cho Button
                    btn.Image = new Bitmap(image, new Size(40, 40));
                }
            }

            btn.Click += (sender, e) =>
            {
                panel_UC.Controls.Clear();
                panel_UC.Controls.Add(userControlname);
                panel_UC.Invalidate();
                panel_UC.PerformLayout();
                label_QuanLi.Text = "Quản Lý " + buttonName;
            };

            PanelTools.Controls.Add(btn);
            pictureBox.Focus();
        }

        private void AddComponent(string buttonName, Panel panelName)
        {
            AddComponent(buttonName, panelName);
        }

        private void SolveEvent()
        {
            // Lấy mã nhân viên đã đăng nhập và thêm vào màn hình chính
            manvLogined = "nv001"; // Đổi thành phương thức để lấy mã nhân viên
            label_MaNV.Text = "Mã :" + manvLogined;

            // Sửa nút button_Thoat
            button_Thoat.Size = new Size(72, 72);
            button_Thoat.ForeColor = Color.White;
            button_Thoat.Font = new Font(button_Thoat.Font.Name, 14, FontStyle.Bold);
            button_Thoat.FlatStyle = FlatStyle.Flat;

            button_Thoat.Click += (sender, e) =>
            {
                (pictureBox.TopLevelControl as Form).Close();
            };

            // Xử lý hoạt ảnh đang hoạt động trên thanh công cụ
            int working = -1;
            for (int i = 0; i < PanelTools.Controls.Count; i++)
            {
                int tmp = i;
                PanelTools.Controls[i].GotFocus += (sender, e) =>
                {
                    if (working >= 0)
                    {
                        (PanelTools.Controls[working] as Button).FlatAppearance.BorderSize = 0;
                    }
                    working = tmp;
                    (PanelTools.Controls[tmp] as Button).FlatAppearance.BorderSize = 5;
                };
            }

            // Sự kiện Phiếu Nhập
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Picture_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
