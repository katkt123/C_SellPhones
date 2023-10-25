using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Hide();
            LoginGUI lg = new LoginGUI();
            lg.StartPosition = FormStartPosition.CenterScreen;
            lg.ShowDialog();
            this.Close();
        }
    }
}
