namespace SellPhones.GUI.UserControls
{
    partial class NhanVienUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox_MK = new TextBox();
            label3 = new Label();
            textBox_TK = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            Sửa = new Button();
            panel2 = new Panel();
            Grid_NhanVien = new DataGridView();
            textBox4 = new TextBox();
            button_Search = new Button();
            textBox_Search = new TextBox();
            comboBox_Type = new ComboBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_NhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox_MK);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox_TK);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(36, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 191);
            panel1.TabIndex = 1;
            // 
            // textBox_MK
            // 
            textBox_MK.Location = new Point(408, 11);
            textBox_MK.Name = "textBox_MK";
            textBox_MK.Size = new Size(166, 27);
            textBox_MK.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 18);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 10;
            label3.Text = "Mật khẩu:";
            // 
            // textBox_TK
            // 
            textBox_TK.Location = new Point(120, 11);
            textBox_TK.Name = "textBox_TK";
            textBox_TK.Size = new Size(166, 27);
            textBox_TK.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 8;
            label1.Text = "Tài khoản:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 27);
            textBox2.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(346, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 82);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(120, 39);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 39);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 153);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 3;
            label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 115);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 2;
            label4.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 64);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên:";
            // 
            // button1
            // 
            button1.Location = new Point(687, 113);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(829, 113);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Sửa
            // 
            Sửa.Location = new Point(760, 166);
            Sửa.Name = "Sửa";
            Sửa.Size = new Size(94, 29);
            Sửa.TabIndex = 4;
            Sửa.Text = "Sửa";
            Sửa.UseVisualStyleBackColor = true;
            Sửa.Click += Sửa_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(Grid_NhanVien);
            panel2.Location = new Point(36, 266);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 214);
            panel2.TabIndex = 5;
            // 
            // Grid_NhanVien
            // 
            Grid_NhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_NhanVien.Dock = DockStyle.Fill;
            Grid_NhanVien.Location = new Point(0, 0);
            Grid_NhanVien.Name = "Grid_NhanVien";
            Grid_NhanVien.RowHeadersWidth = 51;
            Grid_NhanVien.RowTemplate.Height = 29;
            Grid_NhanVien.Size = new Size(900, 214);
            Grid_NhanVien.TabIndex = 0;
            Grid_NhanVien.CellClick += Grid_NhanVien_CellClick;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(744, 31);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 6;
            // 
            // button_Search
            // 
            button_Search.Location = new Point(631, 233);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(101, 27);
            button_Search.TabIndex = 10;
            button_Search.Text = "Tìm Kiếm";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // textBox_Search
            // 
            textBox_Search.Location = new Point(367, 233);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.Size = new Size(258, 27);
            textBox_Search.TabIndex = 9;
            // 
            // comboBox_Type
            // 
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Items.AddRange(new object[] { "Mã Nhân Viên", "Tên Nhân Viên" });
            comboBox_Type.Location = new Point(210, 232);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(151, 28);
            comboBox_Type.TabIndex = 8;
            // 
            // NhanVienUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_Search);
            Controls.Add(textBox_Search);
            Controls.Add(comboBox_Type);
            Controls.Add(textBox4);
            Controls.Add(panel2);
            Controls.Add(Sửa);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "NhanVienUC";
            Size = new Size(980, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_NhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Button button2;
        private Button Sửa;
        private Panel panel2;
        private DataGridView Grid_NhanVien;
        private TextBox textBox_MK;
        private Label label3;
        private TextBox textBox_TK;
        private Label label1;
        private TextBox textBox4;
        private Button button_Search;
        private TextBox textBox_Search;
        private ComboBox comboBox_Type;
    }
}
