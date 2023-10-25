using Sellphone.DAO;
using SellPhones.BUS;
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
using System.Xml.Linq;

namespace SellPhones.GUI
{
    public partial class LoginGUI : Form
    {
        private LoginBUS lgBUS;

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
            DataTable dt = lgBUS.Login(name, pass);
            
            if (dt.Rows.Count <= 0)
            {
                label_Error.Text = "Lỗi: Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng";
                return false;
            }
            else
            {
                string id = Convert.ToString(dt.Rows[0][0]);
                string subs = id.Substring(0, 2);
                lgBUS.active(id);
                if (String.Equals(subs, "AD") || String.Equals(subs, "NV"))
                    return true;
                else return false;
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

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            //if (valid() && login())
            //{
            this.Hide();
            MainGUI main = new MainGUI();
            main.StartPosition = FormStartPosition.CenterScreen;
            main.ShowDialog();
            this.Close();
            //}
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterGUI rf= new RegisterGUI();
            rf.StartPosition = FormStartPosition.CenterScreen;
            rf.ShowDialog();
            this.Close();
        }
    }
}
