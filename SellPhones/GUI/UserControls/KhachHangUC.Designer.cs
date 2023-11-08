namespace SellPhones.GUI.UserControls
{
    partial class KhachHangUC
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
            button_Refresh = new Button();
            textBox_Phone = new TextBox();
            label3 = new Label();
            textBox_Address = new TextBox();
            label2 = new Label();
            textBox_Name = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            Grid_KhachHang = new DataGridView();
            button_Them = new Button();
            button_Sua = new Button();
            button_Xoa = new Button();
            comboBox_Type = new ComboBox();
            textBox_Search = new TextBox();
            button_Search = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_KhachHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Refresh);
            panel1.Controls.Add(textBox_Phone);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox_Address);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_Name);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 157);
            panel1.TabIndex = 0;
            // 
            // button_Refresh
            // 
            button_Refresh.Location = new Point(478, 99);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new Size(125, 31);
            button_Refresh.TabIndex = 6;
            button_Refresh.Text = "Refresh";
            button_Refresh.UseVisualStyleBackColor = true;
            button_Refresh.Click += button_Refresh_Click;
            // 
            // textBox_Phone
            // 
            textBox_Phone.Location = new Point(638, 15);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new Size(290, 27);
            textBox_Phone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(478, 20);
            label3.Name = "label3";
            label3.Size = new Size(125, 22);
            label3.TabIndex = 4;
            label3.Text = "Số Điện Thoại";
            // 
            // textBox_Address
            // 
            textBox_Address.Location = new Point(136, 103);
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(288, 27);
            textBox_Address.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 108);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 2;
            label2.Text = "Địa Chỉ";
            label2.Click += label2_Click;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(136, 15);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(288, 27);
            textBox_Name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 20);
            label1.Name = "label1";
            label1.Size = new Size(69, 22);
            label1.TabIndex = 0;
            label1.Text = "Họ Tên";
            // 
            // panel2
            // 
            panel2.Controls.Add(Grid_KhachHang);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 269);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 231);
            panel2.TabIndex = 1;
            // 
            // Grid_KhachHang
            // 
            Grid_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_KhachHang.Dock = DockStyle.Fill;
            Grid_KhachHang.Location = new Point(0, 0);
            Grid_KhachHang.Name = "Grid_KhachHang";
            Grid_KhachHang.RowHeadersWidth = 51;
            Grid_KhachHang.RowTemplate.Height = 29;
            Grid_KhachHang.Size = new Size(980, 231);
            Grid_KhachHang.TabIndex = 0;
            // 
            // button_Them
            // 
            button_Them.Location = new Point(176, 163);
            button_Them.Name = "button_Them";
            button_Them.Size = new Size(101, 36);
            button_Them.TabIndex = 2;
            button_Them.Text = "Thêm";
            button_Them.UseVisualStyleBackColor = true;
            button_Them.Click += button_Them_Click;
            // 
            // button_Sua
            // 
            button_Sua.Location = new Point(430, 163);
            button_Sua.Name = "button_Sua";
            button_Sua.Size = new Size(101, 36);
            button_Sua.TabIndex = 3;
            button_Sua.Text = "Sửa";
            button_Sua.UseVisualStyleBackColor = true;
            button_Sua.Click += button_Sua_Click;
            // 
            // button_Xoa
            // 
            button_Xoa.Location = new Point(696, 163);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(101, 36);
            button_Xoa.TabIndex = 4;
            button_Xoa.Text = "Xóa";
            button_Xoa.UseVisualStyleBackColor = true;
            button_Xoa.Click += button_Xoa_Click;
            // 
            // comboBox_Type
            // 
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Items.AddRange(new object[] { "Mã Khách Hàng", "Tên Khách Hàng" });
            comboBox_Type.Location = new Point(225, 220);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(151, 28);
            comboBox_Type.TabIndex = 5;
            // 
            // textBox_Search
            // 
            textBox_Search.Location = new Point(382, 220);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.Size = new Size(258, 27);
            textBox_Search.TabIndex = 6;
            // 
            // button_Search
            // 
            button_Search.Location = new Point(646, 221);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(101, 27);
            button_Search.TabIndex = 7;
            button_Search.Text = "Tìm Kiếm";
            button_Search.UseVisualStyleBackColor = true;
            // 
            // KhachHangUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_Search);
            Controls.Add(textBox_Search);
            Controls.Add(comboBox_Type);
            Controls.Add(button_Xoa);
            Controls.Add(button_Sua);
            Controls.Add(button_Them);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "KhachHangUC";
            Size = new Size(980, 500);
            Load += KhachHangUC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_KhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox_Name;
        private Label label1;
        private TextBox textBox_Address;
        private Label label2;
        private Label label3;
        private Button button_Refresh;
        private TextBox textBox_Phone;
        private Button button_Them;
        private Button button_Sua;
        private Button button_Xoa;
        private ComboBox comboBox_Type;
        private TextBox textBox_Search;
        private Button button_Search;
        private DataGridView Grid_KhachHang;
    }
}
