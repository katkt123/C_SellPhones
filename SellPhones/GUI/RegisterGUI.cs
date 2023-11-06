using SellPhones.BUS;
using SellPhones.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SellPhones.GUI
{
    public partial class RegisterGUI : Form
    {
        
        public RegisterGUI()
        {
            InitializeComponent();
        }

        private void RegisterGUI_Load(object sender, EventArgs e)
        {

        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                string user = textBox_TK.Text;
                string pass = textBox_MK.Text;
                string name = textBox_Name.Text;
                string diachi = textBox_DiaChi.Text;
                string sdt = textBox_SDT.Text;

                RegisterBUS.Instance.Register(user, pass, name, diachi, sdt);

                this.Hide();
                LoginGUI lg = new LoginGUI();
                lg.StartPosition = FormStartPosition.CenterScreen;
                lg.ShowDialog();
                this.Close();
            }
        }
        private Boolean valid()
        {
            int emptyFieldCount = 0; // Số trường đang trống

            if (textBox_TK.Text == "")
            {
                emptyFieldCount++;
                txtError.Text = "Bạn Chưa Nhập Tài Khoản  \n ";
            }

            if (textBox_MK.Text == "")
            {
                emptyFieldCount++;
                txtError.Text = "Bạn Chưa Nhập Mật Khẩu \n";
            }

            if (textBox_MK.Text != textBox_ReMK.Text)
            {
                emptyFieldCount++;
                txtError.Text = "Mật Khẩu Không Khớp \n";
            }

            if (textBox_Name.Text == "")
            {
                emptyFieldCount++;
                txtError.Text = "Bạn Chưa Nhập Họ Tên \n";
            }

            if (textBox_SDT.Text == "")
            {
                emptyFieldCount++;
                txtError.Text = "Bạn Chưa Nhập Số Điện Thoại \n";
            }

            if (textBox_DiaChi.Text == "")
            {
                emptyFieldCount++;
                txtError.Text = "Bạn Chưa Nhập Địa Chỉ \n";
            }

            // Kiểm tra số lượng trường trống
            if (emptyFieldCount > 0)
            {
                txtError.Text = $"Có {emptyFieldCount} Ô Chưa Được Nhập Lần Lượt Là :\n";
                return false;
            }

            txtError.Text = "";
            return true;
        }

        private void textBox_TK_Enter(object sender, EventArgs e)
        {
            if (textBox_TK.Text == "UserName")
            {
                textBox_TK.ForeColor = System.Drawing.Color.Black;
                textBox_TK.Text = "";
            }
        }

        private void textBox_TK_Leave(object sender, EventArgs e)
        {
            if (textBox_TK.Text == "")
            {
                textBox_TK.ForeColor = System.Drawing.Color.Gray;
                textBox_TK.Text = "UserName";
            }

        }

        private void textBox_MK_Enter(object sender, EventArgs e)
        {
            if (textBox_MK.Text == "PassWord")
            {
                textBox_MK.ForeColor = System.Drawing.Color.Black;
                textBox_MK.Text = "";
            }
        }

        private void textBox_MK_Leave(object sender, EventArgs e)
        {
            if (textBox_MK.Text == "")
            {
                textBox_MK.ForeColor = System.Drawing.Color.Gray;
                textBox_MK.Text = "PassWord";
            }
        }

        private void textBox_ReMK_Enter(object sender, EventArgs e)
        {
            if (textBox_ReMK.Text == "Re-PassWord")
            {
                textBox_ReMK.ForeColor = System.Drawing.Color.Black;
                textBox_ReMK.Text = "";
            }
        }

        private void textBox_ReMK_Leave(object sender, EventArgs e)
        {
            if (textBox_ReMK.Text == "")
            {
                textBox_ReMK.ForeColor = System.Drawing.Color.Gray;
                textBox_ReMK.Text = "Re-PassWord";
            }
        }

        private void textBox_Name_Enter(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "FullName")
            {
                textBox_Name.ForeColor = System.Drawing.Color.Black;
                textBox_Name.Text = "";
            }
        }

        private void textBox_Name_Leave(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "")
            {
                textBox_Name.ForeColor = System.Drawing.Color.Gray;
                textBox_Name.Text = "FullName";
            }
        }

        private void textBox_DiaChi_Enter(object sender, EventArgs e)
        {
            if (textBox_DiaChi.Text == "Address")
            {
                textBox_DiaChi.ForeColor = System.Drawing.Color.Black;
                textBox_DiaChi.Text = "";
            }
        }

        private void textBox_DiaChi_Leave(object sender, EventArgs e)
        {
            if (textBox_DiaChi.Text == "")
            {
                textBox_DiaChi.ForeColor = System.Drawing.Color.Gray;
                textBox_DiaChi.Text = "Address";
            }
        }

        private void textBox_SDT_Enter(object sender, EventArgs e)
        {
            if (textBox_SDT.Text == "Phone-Number")
            {
                textBox_SDT.ForeColor = System.Drawing.Color.Black;
                textBox_SDT.Text = "";
            }
        }

        private void textBox_SDT_Leave(object sender, EventArgs e)
        {
            if (textBox_SDT.Text == "")
            {
                textBox_SDT.ForeColor = System.Drawing.Color.Gray;
                textBox_SDT.Text = "Phone-Number";
            }
        }
    }
}
