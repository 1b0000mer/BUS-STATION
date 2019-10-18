namespace NHAXE_ENTITIES
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.aboutusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpbookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookworkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listworkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookcustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listcustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkxekhachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checktuyenxeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChuyenXetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lichkhoihanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemdanhmucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // aboutusToolStripMenuItem
            // 
            this.aboutusToolStripMenuItem.Name = "aboutusToolStripMenuItem";
            this.aboutusToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.aboutusToolStripMenuItem.Text = "Về Chúng Tôi";
            this.aboutusToolStripMenuItem.Click += new System.EventHandler(this.aboutusToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.reportToolStripMenuItem.Text = "Gửi Góp Ý";
            // 
            // helpbookToolStripMenuItem
            // 
            this.helpbookToolStripMenuItem.Name = "helpbookToolStripMenuItem";
            this.helpbookToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.helpbookToolStripMenuItem.Text = "Hướng Dẫn";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpbookToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutusToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.helpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // bookworkerToolStripMenuItem
            // 
            this.bookworkerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookworkerToolStripMenuItem.Image")));
            this.bookworkerToolStripMenuItem.Name = "bookworkerToolStripMenuItem";
            this.bookworkerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.bookworkerToolStripMenuItem.Text = "Phân Công";
            this.bookworkerToolStripMenuItem.Click += new System.EventHandler(this.bookworkerToolStripMenuItem_Click);
            // 
            // listworkerToolStripMenuItem
            // 
            this.listworkerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listworkerToolStripMenuItem.Image")));
            this.listworkerToolStripMenuItem.Name = "listworkerToolStripMenuItem";
            this.listworkerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.listworkerToolStripMenuItem.Text = "Quản Lí Nhân Viên";
            this.listworkerToolStripMenuItem.Click += new System.EventHandler(this.listworkerToolStripMenuItem_Click);
            // 
            // workerToolStripMenuItem
            // 
            this.workerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listworkerToolStripMenuItem,
            this.bookworkerToolStripMenuItem});
            this.workerToolStripMenuItem.Name = "workerToolStripMenuItem";
            this.workerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.workerToolStripMenuItem.Text = "Nhân Viên";
            // 
            // bookcustomerToolStripMenuItem
            // 
            this.bookcustomerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookcustomerToolStripMenuItem.Image")));
            this.bookcustomerToolStripMenuItem.Name = "bookcustomerToolStripMenuItem";
            this.bookcustomerToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.bookcustomerToolStripMenuItem.Text = "Đặt Chỗ";
            this.bookcustomerToolStripMenuItem.Click += new System.EventHandler(this.bookcustomerToolStripMenuItem_Click);
            // 
            // listcustomerToolStripMenuItem
            // 
            this.listcustomerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listcustomerToolStripMenuItem.Image")));
            this.listcustomerToolStripMenuItem.Name = "listcustomerToolStripMenuItem";
            this.listcustomerToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listcustomerToolStripMenuItem.Text = "Quản Lí Khách Hàng";
            this.listcustomerToolStripMenuItem.Click += new System.EventHandler(this.listcustomerToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listcustomerToolStripMenuItem,
            this.bookcustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.customerToolStripMenuItem.Text = "Khách Hàng";
            // 
            // checkxekhachToolStripMenuItem
            // 
            this.checkxekhachToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checkxekhachToolStripMenuItem.Image")));
            this.checkxekhachToolStripMenuItem.Name = "checkxekhachToolStripMenuItem";
            this.checkxekhachToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.checkxekhachToolStripMenuItem.Text = "Tra Cứu Loại Xe";
            this.checkxekhachToolStripMenuItem.Click += new System.EventHandler(this.checkxekhachToolStripMenuItem_Click);
            // 
            // checktuyenxeToolStripMenuItem
            // 
            this.checktuyenxeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checktuyenxeToolStripMenuItem.Image")));
            this.checktuyenxeToolStripMenuItem.Name = "checktuyenxeToolStripMenuItem";
            this.checktuyenxeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.checktuyenxeToolStripMenuItem.Text = "Tra Cứu Tuyến Xe";
            this.checktuyenxeToolStripMenuItem.Click += new System.EventHandler(this.checktuyenxeToolStripMenuItem_Click);
            // 
            // ChuyenXetoolStripMenuItem
            // 
            this.ChuyenXetoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ChuyenXetoolStripMenuItem.Image")));
            this.ChuyenXetoolStripMenuItem.Name = "ChuyenXetoolStripMenuItem";
            this.ChuyenXetoolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ChuyenXetoolStripMenuItem.Text = "Tra Cứu Chuyến Xe";
            this.ChuyenXetoolStripMenuItem.Click += new System.EventHandler(this.ChuyenXetoolStripMenuItem_Click);
            // 
            // lichkhoihanhToolStripMenuItem
            // 
            this.lichkhoihanhToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lichkhoihanhToolStripMenuItem.Image")));
            this.lichkhoihanhToolStripMenuItem.Name = "lichkhoihanhToolStripMenuItem";
            this.lichkhoihanhToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.lichkhoihanhToolStripMenuItem.Text = "Lịch Khởi Hành";
            this.lichkhoihanhToolStripMenuItem.Click += new System.EventHandler(this.lichkhoihanhToolStripMenuItem_Click);
            // 
            // xemdanhmucToolStripMenuItem
            // 
            this.xemdanhmucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lichkhoihanhToolStripMenuItem,
            this.ChuyenXetoolStripMenuItem,
            this.checktuyenxeToolStripMenuItem,
            this.checkxekhachToolStripMenuItem});
            this.xemdanhmucToolStripMenuItem.Name = "xemdanhmucToolStripMenuItem";
            this.xemdanhmucToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.xemdanhmucToolStripMenuItem.Text = "Xem Danh Mục";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 456);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(930, 456);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTime.Location = new System.Drawing.Point(966, 45);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(265, 57);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "label1";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(998, 111);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(957, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 99);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(119, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "16110CL3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(89, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trần Đăng Khôi Nguyên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(116, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nguyễn Thiên Quốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(81, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Người thực hiện:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.xemdanhmucToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.workerToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1261, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.systemToolStripMenuItem.Text = "Hệ Thống";
            // 
            // logoutStripMenuItem
            // 
            this.logoutStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutStripMenuItem.Image")));
            this.logoutStripMenuItem.Name = "logoutStripMenuItem";
            this.logoutStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.logoutStripMenuItem.Text = "Đăng Xuất";
            this.logoutStripMenuItem.Click += new System.EventHandler(this.logoutStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(625, -27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ NHÀ XE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Quản Lý Nhà Xe";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripMenuItem aboutusToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpbookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookworkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listworkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookcustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listcustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkxekhachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checktuyenxeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChuyenXetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lichkhoihanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemdanhmucToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}