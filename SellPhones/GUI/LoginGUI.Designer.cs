namespace SellPhones.GUI
{
    partial class LoginGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGUI));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label_Error = new Label();
            label_Forgot = new Label();
            button_SignUp = new Button();
            button_SignIn = new Button();
            textBox_MK = new TextBox();
            label3 = new Label();
            textBox_TK = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 603);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGoldenrod;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(538, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(659, 603);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(label_Error);
            panel3.Controls.Add(label_Forgot);
            panel3.Controls.Add(button_SignUp);
            panel3.Controls.Add(button_SignIn);
            panel3.Controls.Add(textBox_MK);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox_TK);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(75, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(551, 481);
            panel3.TabIndex = 3;
            // 
            // label_Error
            // 
            label_Error.AutoSize = true;
            label_Error.BackColor = Color.PaleGoldenrod;
            label_Error.ForeColor = Color.Red;
            label_Error.Location = new Point(24, 281);
            label_Error.Name = "label_Error";
            label_Error.Size = new Size(0, 20);
            label_Error.TabIndex = 7;
            // 
            // label_Forgot
            // 
            label_Forgot.AutoSize = true;
            label_Forgot.BackColor = Color.PaleGoldenrod;
            label_Forgot.Location = new Point(401, 378);
            label_Forgot.Name = "label_Forgot";
            label_Forgot.Size = new Size(116, 20);
            label_Forgot.TabIndex = 6;
            label_Forgot.Text = "Quên mật khẩu?";
            // 
            // button_SignUp
            // 
            button_SignUp.Location = new Point(297, 304);
            button_SignUp.Name = "button_SignUp";
            button_SignUp.Size = new Size(222, 44);
            button_SignUp.TabIndex = 5;
            button_SignUp.Text = "Đăng Ký";
            button_SignUp.UseVisualStyleBackColor = true;
            button_SignUp.Click += button_SignUp_Click;
            // 
            // button_SignIn
            // 
            button_SignIn.BackColor = Color.Gold;
            button_SignIn.ForeColor = SystemColors.ControlText;
            button_SignIn.Location = new Point(24, 304);
            button_SignIn.Name = "button_SignIn";
            button_SignIn.Size = new Size(222, 44);
            button_SignIn.TabIndex = 4;
            button_SignIn.Text = "Đăng Nhập";
            button_SignIn.UseVisualStyleBackColor = false;
            button_SignIn.Click += button_SignIn_Click;
            // 
            // textBox_MK
            // 
            textBox_MK.Location = new Point(24, 229);
            textBox_MK.Name = "textBox_MK";
            textBox_MK.PasswordChar = '*';
            textBox_MK.Size = new Size(495, 27);
            textBox_MK.TabIndex = 3;
            textBox_MK.Enter += textBox_MK_Enter;
            textBox_MK.Leave += textBox_MK_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleGoldenrod;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 183);
            label3.Name = "label3";
            label3.Size = new Size(112, 31);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // textBox_TK
            // 
            textBox_TK.Location = new Point(24, 118);
            textBox_TK.Name = "textBox_TK";
            textBox_TK.Size = new Size(495, 27);
            textBox_TK.TabIndex = 1;
            textBox_TK.Enter += textBox_TK_Enter;
            textBox_TK.Leave += textBox_TK_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleGoldenrod;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 65);
            label2.Name = "label2";
            label2.Size = new Size(111, 31);
            label2.TabIndex = 0;
            label2.Text = "Tài Khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(225, 22);
            label1.Name = "label1";
            label1.Size = new Size(266, 62);
            label1.TabIndex = 2;
            label1.Text = "Đăng Nhập";
            // 
            // LoginGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 603);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1215, 650);
            MinimumSize = new Size(1215, 650);
            Name = "LoginGUI";
            Text = "LoginGUI";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TextBox textBox_TK;
        private TextBox textBox_MK;
        private Label label3;
        private Label label2;
        private Button button_SignUp;
        private Button button_SignIn;
        private Label label_Forgot;
        private Label label_Error;
    }
}