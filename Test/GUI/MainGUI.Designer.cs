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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            fileSystemWatcher1 = new FileSystemWatcher();
            panel2 = new Panel();
            label_QuanLi = new Label();
            label_MaNV = new Label();
            button_Thoat = new Button();
            panel_UC = new Panel();
            PanelTools = new FlowLayoutPanel();
            pictureBox = new PictureBox();
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
            panel2.Controls.Add(label_QuanLi);
            panel2.Controls.Add(label_MaNV);
            panel2.Controls.Add(button_Thoat);
            panel2.Location = new Point(206, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 80);
            panel2.TabIndex = 2;
            // 
            // label_QuanLi
            // 
            label_QuanLi.AutoSize = true;
            label_QuanLi.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label_QuanLi.Location = new Point(3, 6);
            label_QuanLi.Name = "label_QuanLi";
            label_QuanLi.Size = new Size(198, 67);
            label_QuanLi.TabIndex = 3;
            label_QuanLi.Text = "Quản Lí";
            label_QuanLi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_MaNV
            // 
            label_MaNV.AutoSize = true;
            label_MaNV.Location = new Point(723, 29);
            label_MaNV.Name = "label_MaNV";
            label_MaNV.Size = new Size(61, 20);
            label_MaNV.TabIndex = 1;
            label_MaNV.Text = "Mã NV :";
            label_MaNV.Click += label1_Click;
            // 
            // button_Thoat
            // 
            button_Thoat.Location = new Point(883, 9);
            button_Thoat.Name = "button_Thoat";
            button_Thoat.Size = new Size(94, 60);
            button_Thoat.TabIndex = 0;
            button_Thoat.Text = "button1";
            button_Thoat.UseVisualStyleBackColor = true;
            // 
            // panel_UC
            // 
            panel_UC.Location = new Point(206, 91);
            panel_UC.Name = "panel_UC";
            panel_UC.Size = new Size(980, 500);
            panel_UC.TabIndex = 3;
            // 
            // PanelTools
            // 
            PanelTools.Location = new Point(0, 91);
            PanelTools.Name = "PanelTools";
            PanelTools.Size = new Size(200, 500);
            PanelTools.TabIndex = 5;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(0, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(200, 80);
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // MainGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 603);
            Controls.Add(pictureBox);
            Controls.Add(PanelTools);
            Controls.Add(panel_UC);
            Controls.Add(panel2);
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
        private FlowLayoutPanel PanelTools;
        private PictureBox pictureBox;
    }
}