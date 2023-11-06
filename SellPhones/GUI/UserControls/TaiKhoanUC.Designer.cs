namespace SellPhones.GUI.UserControls
{
    partial class TaiKhoanUC
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
            tabControl1 = new TabControl();
            tabPage_TK = new TabPage();
            button_Refresh = new Button();
            button_Search = new Button();
            textBox_Search = new TextBox();
            comboBox_Type = new ComboBox();
            button_Sua = new Button();
            button_Xoa = new Button();
            button_Them = new Button();
            panel2 = new Panel();
            textBox_MK = new TextBox();
            label2 = new Label();
            textBox_TK = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            Grid_TaiKhoan = new DataGridView();
            tabPage_Quyen = new TabPage();
            button6 = new Button();
            comboBox2 = new ComboBox();
            panel3 = new Panel();
            Grid_Quyen = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage_TK.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_TaiKhoan).BeginInit();
            tabPage_Quyen.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Quyen).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_TK);
            tabControl1.Controls.Add(tabPage_Quyen);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(980, 500);
            tabControl1.TabIndex = 0;
            // 
            // tabPage_TK
            // 
            tabPage_TK.Controls.Add(button_Refresh);
            tabPage_TK.Controls.Add(button_Search);
            tabPage_TK.Controls.Add(textBox_Search);
            tabPage_TK.Controls.Add(comboBox_Type);
            tabPage_TK.Controls.Add(button_Sua);
            tabPage_TK.Controls.Add(button_Xoa);
            tabPage_TK.Controls.Add(button_Them);
            tabPage_TK.Controls.Add(panel2);
            tabPage_TK.Controls.Add(panel1);
            tabPage_TK.Location = new Point(4, 29);
            tabPage_TK.Name = "tabPage_TK";
            tabPage_TK.Padding = new Padding(3);
            tabPage_TK.Size = new Size(972, 467);
            tabPage_TK.TabIndex = 0;
            tabPage_TK.Text = "Tài Khoản";
            tabPage_TK.UseVisualStyleBackColor = true;
            tabPage_TK.Click += tabPage_TK_Click;
            // 
            // button_Refresh
            // 
            button_Refresh.Location = new Point(416, 73);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new Size(39, 39);
            button_Refresh.TabIndex = 15;
            button_Refresh.UseVisualStyleBackColor = true;
            button_Refresh.Click += button_Refresh_Click;
            // 
            // button_Search
            // 
            button_Search.Location = new Point(817, 138);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(137, 29);
            button_Search.TabIndex = 14;
            button_Search.Text = "Tìm Kiếm";
            button_Search.UseVisualStyleBackColor = true;
            // 
            // textBox_Search
            // 
            textBox_Search.Location = new Point(542, 138);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.Size = new Size(246, 27);
            textBox_Search.TabIndex = 13;
            // 
            // comboBox_Type
            // 
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Items.AddRange(new object[] { "Mã Tài Khoản", "Tên Tài Khoản" });
            comboBox_Type.Location = new Point(416, 138);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(101, 28);
            comboBox_Type.TabIndex = 12;
            // 
            // button_Sua
            // 
            button_Sua.Location = new Point(606, 11);
            button_Sua.Name = "button_Sua";
            button_Sua.Size = new Size(151, 35);
            button_Sua.TabIndex = 10;
            button_Sua.Text = "Sửa";
            button_Sua.UseVisualStyleBackColor = true;
            button_Sua.Click += button_Sua_Click;
            // 
            // button_Xoa
            // 
            button_Xoa.Location = new Point(803, 11);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(151, 35);
            button_Xoa.TabIndex = 9;
            button_Xoa.Text = "Xóa";
            button_Xoa.UseVisualStyleBackColor = true;
            button_Xoa.Click += button_Xoa_Click;
            // 
            // button_Them
            // 
            button_Them.Location = new Point(416, 10);
            button_Them.Name = "button_Them";
            button_Them.Size = new Size(151, 35);
            button_Them.TabIndex = 8;
            button_Them.Text = "Thêm";
            button_Them.UseVisualStyleBackColor = true;
            button_Them.Click += button_Them_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox_MK);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_TK);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 155);
            panel2.TabIndex = 2;
            // 
            // textBox_MK
            // 
            textBox_MK.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MK.Location = new Point(19, 116);
            textBox_MK.Name = "textBox_MK";
            textBox_MK.Size = new Size(334, 23);
            textBox_MK.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 91);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu";
            // 
            // textBox_TK
            // 
            textBox_TK.Location = new Point(19, 37);
            textBox_TK.Name = "textBox_TK";
            textBox_TK.Size = new Size(334, 27);
            textBox_TK.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(128, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên Tài Khoản";
            // 
            // panel1
            // 
            panel1.Controls.Add(Grid_TaiKhoan);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 199);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 265);
            panel1.TabIndex = 1;
            // 
            // Grid_TaiKhoan
            // 
            Grid_TaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_TaiKhoan.Dock = DockStyle.Fill;
            Grid_TaiKhoan.Location = new Point(0, 0);
            Grid_TaiKhoan.Name = "Grid_TaiKhoan";
            Grid_TaiKhoan.RowHeadersWidth = 51;
            Grid_TaiKhoan.RowTemplate.Height = 29;
            Grid_TaiKhoan.Size = new Size(966, 265);
            Grid_TaiKhoan.TabIndex = 0;
            Grid_TaiKhoan.CellContentClick += Grid_TaiKhoan_CellContentClick;
            // 
            // tabPage_Quyen
            // 
            tabPage_Quyen.Controls.Add(button6);
            tabPage_Quyen.Controls.Add(comboBox2);
            tabPage_Quyen.Controls.Add(panel3);
            tabPage_Quyen.Location = new Point(4, 29);
            tabPage_Quyen.Name = "tabPage_Quyen";
            tabPage_Quyen.Padding = new Padding(3);
            tabPage_Quyen.Size = new Size(972, 467);
            tabPage_Quyen.TabIndex = 1;
            tabPage_Quyen.Text = "Quyền";
            tabPage_Quyen.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(359, 68);
            button6.Name = "button6";
            button6.Size = new Size(238, 54);
            button6.TabIndex = 2;
            button6.Text = "Cấp Quyền";
            button6.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Quản Lý", "Nhân Viên" });
            comboBox2.Location = new Point(374, 22);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(211, 28);
            comboBox2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(Grid_Quyen);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(966, 308);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // Grid_Quyen
            // 
            Grid_Quyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Quyen.Dock = DockStyle.Fill;
            Grid_Quyen.Location = new Point(0, 0);
            Grid_Quyen.Name = "Grid_Quyen";
            Grid_Quyen.RowHeadersWidth = 51;
            Grid_Quyen.RowTemplate.Height = 29;
            Grid_Quyen.Size = new Size(966, 308);
            Grid_Quyen.TabIndex = 0;
            // 
            // TaiKhoanUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "TaiKhoanUC";
            Size = new Size(980, 500);
            tabControl1.ResumeLayout(false);
            tabPage_TK.ResumeLayout(false);
            tabPage_TK.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_TaiKhoan).EndInit();
            tabPage_Quyen.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_Quyen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage_TK;
        private TabPage tabPage_Quyen;
        private Panel panel1;
        private DataGridView Grid_TaiKhoan;
        private Label label1;
        private Panel panel2;
        private Button button_Them;
        private TextBox textBox_MK;
        private Label label2;
        private TextBox textBox_TK;
        private Button button_Sua;
        private Button button_Xoa;
        private Button button_Search;
        private TextBox textBox_Search;
        private ComboBox comboBox_Type;
        private Button button_Refresh;
        private Panel panel3;
        private DataGridView Grid_Quyen;
        private Button button6;
        private ComboBox comboBox2;
    }
}
