using Sellphone.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhones.GUI
{
    public partial class LoginGUI : Form
    {

        public LoginGUI()
        {
            InitializeComponent();

        }
        public Boolean valid()
        {
            string name = textBox_TK.Text;
            string pass = textBox_MK.Text;
            if (name == "")
            {
                label_Error.Text = "Lỗi: Bạn Chưa Nhập Tài Khoản";
                return false;
            }
            if (pass == "")
            {
                label_Error.Text = "Lỗi: Bạn Chưa Nhập Mật Khẩu";
                return false;
            }
            label_Error.Text = "";
            return true;
        }

        private Boolean login()
        {
            string name = textBox_TK.Text;
            string pass = textBox_MK.Text;
            DataTable dt = LoginDAO.Instance.Login(name, pass);
            if (dt.Rows.Count <= 0)
            {
                label_Error.Text = "Lỗi: Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng";
                return false;
            }
            else
            {
                string text = Convert.ToString(dt.Rows[0][4]);
                string[] subs = text.Split(' ');
                string permission = subs[0];
                if (String.Equals(permission, "AD") || String.Equals(permission, "NV"))
                    return true;
                else
                {
                    MessageBox.Show("You dont have permission to login here");
                    return false;
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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

            if (textBox_MK.Text == "Password")
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
    }
}
