namespace SellPhones.GUI
{
    partial class RegisterGUI
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
            panel1 = new Panel();
            txtError = new TextBox();
            textBox_ReMK = new TextBox();
            label7 = new Label();
            textBox_SDT = new TextBox();
            textBox_DiaChi = new TextBox();
            textBox_Name = new TextBox();
            textBox_MK = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox_TK = new TextBox();
            label2 = new Label();
            button_Register = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtError);
            panel1.Controls.Add(textBox_ReMK);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox_SDT);
            panel1.Controls.Add(textBox_DiaChi);
            panel1.Controls.Add(textBox_Name);
            panel1.Controls.Add(textBox_MK);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox_TK);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button_Register);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(378, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 604);
            panel1.TabIndex = 0;
            // 
            // txtError
            // 
            txtError.BackColor = Color.PaleGoldenrod;
            txtError.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtError.ForeColor = Color.Red;
            txtError.Location = new Point(31, 527);
            txtError.Multiline = true;
            txtError.Name = "txtError";
            txtError.Size = new Size(429, 27);
            txtError.TabIndex = 15;
            // 
            // textBox_ReMK
            // 
            textBox_ReMK.Location = new Point(31, 276);
            textBox_ReMK.Name = "textBox_ReMK";
            textBox_ReMK.PasswordChar = '*';
            textBox_ReMK.Size = new Size(430, 27);
            textBox_ReMK.TabIndex = 13;
            textBox_ReMK.Text = "Re-PassWord";
            textBox_ReMK.Enter += textBox_ReMK_Enter;
            textBox_ReMK.Leave += textBox_ReMK_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(31, 244);
            label7.Name = "label7";
            label7.Size = new Size(194, 26);
            label7.TabIndex = 12;
            label7.Text = "Nhập Lại Mật Khẩu";
            // 
            // textBox_SDT
            // 
            textBox_SDT.Location = new Point(31, 489);
            textBox_SDT.Name = "textBox_SDT";
            textBox_SDT.Size = new Size(430, 27);
            textBox_SDT.TabIndex = 11;
            textBox_SDT.Text = "Phone-Number";
            textBox_SDT.Enter += textBox_SDT_Enter;
            textBox_SDT.Leave += textBox_SDT_Leave;
            // 
            // textBox_DiaChi
            // 
            textBox_DiaChi.Location = new Point(31, 417);
            textBox_DiaChi.Name = "textBox_DiaChi";
            textBox_DiaChi.Size = new Size(430, 27);
            textBox_DiaChi.TabIndex = 10;
            textBox_DiaChi.Text = "Address";
            textBox_DiaChi.Enter += textBox_DiaChi_Enter;
            textBox_DiaChi.Leave += textBox_DiaChi_Leave;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(31, 347);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(430, 27);
            textBox_Name.TabIndex = 9;
            textBox_Name.Text = "FullName";
            textBox_Name.Enter += textBox_Name_Enter;
            textBox_Name.Leave += textBox_Name_Leave;
            // 
            // textBox_MK
            // 
            textBox_MK.Location = new Point(31, 201);
            textBox_MK.Name = "textBox_MK";
            textBox_MK.PasswordChar = '*';
            textBox_MK.Size = new Size(430, 27);
            textBox_MK.TabIndex = 8;
            textBox_MK.Text = "PassWord";
            textBox_MK.Enter += textBox_MK_Enter;
            textBox_MK.Leave += textBox_MK_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(31, 459);
            label6.Name = "label6";
            label6.Size = new Size(148, 26);
            label6.TabIndex = 7;
            label6.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 387);
            label5.Name = "label5";
            label5.Size = new Size(84, 26);
            label5.TabIndex = 6;
            label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 316);
            label4.Name = "label4";
            label4.Size = new Size(109, 26);
            label4.TabIndex = 5;
            label4.Text = "Họ và Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 171);
            label3.Name = "label3";
            label3.Size = new Size(103, 26);
            label3.TabIndex = 4;
            label3.Text = "Mật Khẩu";
            // 
            // textBox_TK
            // 
            textBox_TK.Location = new Point(31, 132);
            textBox_TK.Name = "textBox_TK";
            textBox_TK.Size = new Size(430, 27);
            textBox_TK.TabIndex = 3;
            textBox_TK.Text = "UserName";
            textBox_TK.Enter += textBox_TK_Enter;
            textBox_TK.Leave += textBox_TK_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 101);
            label2.Name = "label2";
            label2.Size = new Size(110, 26);
            label2.TabIndex = 2;
            label2.Text = "Tài Khoản";
            // 
            // button_Register
            // 
            button_Register.BackColor = Color.Gold;
            button_Register.Location = new Point(125, 557);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(233, 42);
            button_Register.TabIndex = 1;
            button_Register.Text = "Đăng Ký";
            button_Register.UseVisualStyleBackColor = false;
            button_Register.Click += button_Register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 34.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(125, 17);
            label1.Name = "label1";
            label1.Size = new Size(233, 65);
            label1.TabIndex = 0;
            label1.Text = "Đăng Ký";
            // 
            // RegisterGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1197, 603);
            Controls.Add(panel1);
            Name = "RegisterGUI";
            Text = "RegisterGUI";
            Load += RegisterGUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button_Register;
        private TextBox textBox_TK;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox_SDT;
        private TextBox textBox_DiaChi;
        private TextBox textBox_Name;
        private TextBox textBox_MK;
        private Label label6;
        private Label label7;
        private TextBox textBox_ReMK;
        private TextBox txtError;
    }
}