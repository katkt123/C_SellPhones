namespace SellPhones.GUI.UserControls
{
    partial class KhuyenMaiUC
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
            Grid_KhuyenMai = new DataGridView();
            label1 = new Label();
            textBox_search = new TextBox();
            button_timkiem = new Button();
            button_tao = new Button();
            button_xoa = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_KhuyenMai).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Grid_KhuyenMai);
            panel1.Location = new Point(205, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 320);
            panel1.TabIndex = 0;
            // 
            // Grid_KhuyenMai
            // 
            Grid_KhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_KhuyenMai.Dock = DockStyle.Fill;
            Grid_KhuyenMai.Location = new Point(0, 0);
            Grid_KhuyenMai.Name = "Grid_KhuyenMai";
            Grid_KhuyenMai.RowHeadersWidth = 51;
            Grid_KhuyenMai.RowTemplate.Height = 29;
            Grid_KhuyenMai.Size = new Size(748, 318);
            Grid_KhuyenMai.TabIndex = 0;
            Grid_KhuyenMai.CellClick += Grid_KhuyenMai_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(20, 19);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 1;
            label1.Text = "KHUYẾN MÃI";
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(205, 23);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(312, 27);
            textBox_search.TabIndex = 2;
            // 
            // button_timkiem
            // 
            button_timkiem.Location = new Point(523, 22);
            button_timkiem.Name = "button_timkiem";
            button_timkiem.Size = new Size(94, 29);
            button_timkiem.TabIndex = 3;
            button_timkiem.Text = "Tìm kiếm";
            button_timkiem.UseVisualStyleBackColor = true;
            button_timkiem.Click += button_timkiem_Click;
            // 
            // button_tao
            // 
            button_tao.Location = new Point(720, 23);
            button_tao.Name = "button_tao";
            button_tao.Size = new Size(94, 29);
            button_tao.TabIndex = 4;
            button_tao.Text = "Tạo";
            button_tao.UseVisualStyleBackColor = true;
            button_tao.Click += button_tao_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(840, 23);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 29);
            button_xoa.TabIndex = 5;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(384, 82);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(674, 82);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(187, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(302, 82);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 8;
            label2.Text = "Từ ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(585, 86);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 9;
            label3.Text = "Đến ngày";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(22, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(142, 139);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trạng thái";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 98);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(70, 24);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tất cả";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 68);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(82, 24);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hết hạn";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 24);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Còn hạn";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(823, 126);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Làm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // KhuyenMaiUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button_xoa);
            Controls.Add(button_tao);
            Controls.Add(button_timkiem);
            Controls.Add(textBox_search);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "KhuyenMaiUC";
            Size = new Size(980, 500);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_KhuyenMai).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView Grid_KhuyenMai;
        private Label label1;
        private TextBox textBox_search;
        private Button button_timkiem;
        private Button button_tao;
        private Button button_xoa;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
    }
}
