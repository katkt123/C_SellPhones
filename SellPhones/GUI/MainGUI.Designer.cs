namespace SellPhones.GUI
{
    partial class MainGUI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            fileSystemWatcher1 = new FileSystemWatcher();
            panel2 = new Panel();
            label1 = new Label();
            label_QuanLi = new Label();
            label_MaNV = new Label();
            button_Thoat = new Button();
            panel_UC = new Panel();
            pictureBox = new PictureBox();
            PanelTools = new FlowLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGoldenrod;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label_QuanLi);
            panel2.Controls.Add(label_MaNV);
            panel2.Controls.Add(button_Thoat);
            panel2.Location = new Point(206, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 80);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(566, 7);
            label1.Name = "label1";
            label1.Size = new Size(158, 66);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label_QuanLi
            // 
            label_QuanLi.AutoSize = true;
            label_QuanLi.Font = new Font("Times New Roman", 34.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_QuanLi.Location = new Point(3, 6);
            label_QuanLi.Name = "label_QuanLi";
            label_QuanLi.Size = new Size(269, 65);
            label_QuanLi.TabIndex = 3;
            label_QuanLi.Text = "Trang Chủ";
            label_QuanLi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_MaNV
            // 
            label_MaNV.AutoSize = true;
            label_MaNV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_MaNV.Location = new Point(723, 29);
            label_MaNV.Name = "label_MaNV";
            label_MaNV.Size = new Size(0, 22);
            label_MaNV.TabIndex = 1;
            label_MaNV.Click += label1_Click;
            // 
            // button_Thoat
            // 
            button_Thoat.AllowDrop = true;
            button_Thoat.BackColor = Color.PaleGoldenrod;
            button_Thoat.BackgroundImage = (Image)resources.GetObject("button_Thoat.BackgroundImage");
            button_Thoat.Location = new Point(905, 4);
            button_Thoat.Name = "button_Thoat";
            button_Thoat.Size = new Size(72, 72);
            button_Thoat.TabIndex = 0;
            button_Thoat.UseVisualStyleBackColor = false;
            button_Thoat.Click += button_Thoat_Click;
            // 
            // panel_UC
            // 
            panel_UC.Location = new Point(206, 91);
            panel_UC.Name = "panel_UC";
            panel_UC.Size = new Size(980, 500);
            panel_UC.TabIndex = 3;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(200, 80);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // PanelTools
            // 
            PanelTools.AutoScroll = true;
            PanelTools.BackColor = Color.PaleGoldenrod;
            PanelTools.Location = new Point(0, 91);
            PanelTools.Name = "PanelTools";
            PanelTools.Size = new Size(200, 500);
            PanelTools.TabIndex = 7;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 595);
            Controls.Add(PanelTools);
            Controls.Add(pictureBox);
            Controls.Add(panel_UC);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1215, 650);
            MinimumSize = new Size(1000, 550);
            Name = "MainGUI";
            Text = "MainGUI";
            Load += MainGUI_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel2;
        private Panel panel_UC;
        private Button button_Thoat;
        private Label label_MaNV;
        private Label label_QuanLi;
        private PictureBox pictureBox;
        private FlowLayoutPanel PanelTools;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}