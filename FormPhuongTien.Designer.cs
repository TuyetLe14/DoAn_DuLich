namespace DoAn_DuLich_LTC085A0003_LTC085A0004
{
    partial class FormPhuongTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhuongTien));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.cboNoiDen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNoiKhoiHanh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPhuongTien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.lwDatCho = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwChoNgoi = new System.Windows.Forms.ListView();
            this.imgGhe = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThue_Tra = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.cboNoiDen);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoDienThoai);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.cboNoiKhoiHanh);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cboPhuongTien);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip);
            this.splitContainer1.Panel2.Controls.Add(this.lwDatCho);
            this.splitContainer1.Panel2.Controls.Add(this.lwChoNgoi);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(823, 415);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "THÔNG TIN PHƯƠNG TIỆN";
            // 
            // cboNoiDen
            // 
            this.cboNoiDen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNoiDen.FormattingEnabled = true;
            this.cboNoiDen.Items.AddRange(new object[] {
            "Điện Biên",
            "Hòa Bình",
            "Lai Châu",
            "Lào Cai",
            "Sơn La",
            "Yên Bái",
            "Bắc Giang",
            "Bắc Kạn",
            "Cao Bằng",
            "Hà Giang",
            "Lạng Sơn",
            "Phú Thọ",
            "Quảng Ninh",
            "Thái Nguyên",
            "Tuyên Quang",
            "Bắc Ninh",
            "Hà Nam",
            "Thành phố Hà Nội",
            "Hải Dương",
            "Thành phố Hải Phòng",
            "Hưng Yên",
            "Nam Định",
            "Ninh Bình",
            "Thái Bình",
            "Vĩnh Phúc",
            "Hà Tĩnh",
            "Nghệ An",
            "Quảng Bình",
            "Quảng Trị",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Bình Định",
            "Bình Thuận",
            "Thành phố Đà Nẵng",
            "Khánh Hòa",
            "Ninh Thuận",
            "Phú Yên",
            "Quảng Nam",
            "Quảng Ngãi",
            "Đắk Lắk",
            "Đắk Nông",
            "Gia Lai",
            "Kon Tum",
            "Lâm Đồng",
            "Bà Rịa Vũng Tàu",
            "Bình Dương",
            "Bình Phước",
            "Đồng Nai",
            "Tp.Hồ Chí Minh",
            "Tây Ninh",
            "An Giang",
            "Bạc Liêu",
            "Bến Tre",
            "Cà Mau",
            "Cần Thơ",
            "Đồng Tháp",
            "Hậu Giang",
            "Kiên Giang",
            "Long An",
            "Sóc Trăng",
            "Tiền Giang",
            "Trà Vinh",
            "Vĩnh Long"});
            this.cboNoiDen.Location = new System.Drawing.Point(118, 121);
            this.cboNoiDen.Margin = new System.Windows.Forms.Padding(2);
            this.cboNoiDen.Name = "cboNoiDen";
            this.cboNoiDen.Size = new System.Drawing.Size(129, 23);
            this.cboNoiDen.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Đến:";
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(39, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 166);
            this.label5.TabIndex = 37;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(118, 157);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(129, 22);
            this.txtSoDienThoai.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Số điện thoại:";
            // 
            // cboNoiKhoiHanh
            // 
            this.cboNoiKhoiHanh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNoiKhoiHanh.FormattingEnabled = true;
            this.cboNoiKhoiHanh.Items.AddRange(new object[] {
            "Điện Biên",
            "Hòa Bình",
            "Lai Châu",
            "Lào Cai",
            "Sơn La",
            "Yên Bái",
            "Bắc Giang",
            "Bắc Kạn",
            "Cao Bằng",
            "Hà Giang",
            "Lạng Sơn",
            "Phú Thọ",
            "Quảng Ninh",
            "Thái Nguyên",
            "Tuyên Quang",
            "Bắc Ninh",
            "Hà Nam",
            "Thành phố Hà Nội",
            "Hải Dương",
            "Thành phố Hải Phòng",
            "Hưng Yên",
            "Nam Định",
            "Ninh Bình",
            "Thái Bình",
            "Vĩnh Phúc",
            "Hà Tĩnh",
            "Nghệ An",
            "Quảng Bình",
            "Quảng Trị",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Bình Định",
            "Bình Thuận",
            "Thành phố Đà Nẵng",
            "Khánh Hòa",
            "Ninh Thuận",
            "Phú Yên",
            "Quảng Nam",
            "Quảng Ngãi",
            "Đắk Lắk",
            "Đắk Nông",
            "Gia Lai",
            "Kon Tum",
            "Lâm Đồng",
            "Bà Rịa Vũng Tàu",
            "Bình Dương",
            "Bình Phước",
            "Đồng Nai",
            "Tp.Hồ Chí Minh",
            "Tây Ninh",
            "An Giang",
            "Bạc Liêu",
            "Bến Tre",
            "Cà Mau",
            "Cần Thơ",
            "Đồng Tháp",
            "Hậu Giang",
            "Kiên Giang",
            "Long An",
            "Sóc Trăng",
            "Tiền Giang",
            "Trà Vinh",
            "Vĩnh Long"});
            this.cboNoiKhoiHanh.Location = new System.Drawing.Point(118, 89);
            this.cboNoiKhoiHanh.Margin = new System.Windows.Forms.Padding(2);
            this.cboNoiKhoiHanh.Name = "cboNoiKhoiHanh";
            this.cboNoiKhoiHanh.Size = new System.Drawing.Size(129, 23);
            this.cboNoiKhoiHanh.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nơi khởi hành:";
            // 
            // cboPhuongTien
            // 
            this.cboPhuongTien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhuongTien.FormattingEnabled = true;
            this.cboPhuongTien.Items.AddRange(new object[] {
            "Tàu hỏa",
            "Máy bay",
            "Xe khách"});
            this.cboPhuongTien.Location = new System.Drawing.Point(118, 57);
            this.cboPhuongTien.Margin = new System.Windows.Forms.Padding(2);
            this.cboPhuongTien.Name = "cboPhuongTien";
            this.cboPhuongTien.Size = new System.Drawing.Size(129, 23);
            this.cboPhuongTien.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Loại phương tiện:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "BOOK VÉ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(546, 29);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(70, 27);
            this.mnuThoat.Text = "&Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // lwDatCho
            // 
            this.lwDatCho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lwDatCho.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwDatCho.FullRowSelect = true;
            this.lwDatCho.GridLines = true;
            this.lwDatCho.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lwDatCho.HideSelection = false;
            this.lwDatCho.Location = new System.Drawing.Point(246, 66);
            this.lwDatCho.Margin = new System.Windows.Forms.Padding(2);
            this.lwDatCho.MultiSelect = false;
            this.lwDatCho.Name = "lwDatCho";
            this.lwDatCho.Size = new System.Drawing.Size(293, 343);
            this.lwDatCho.TabIndex = 18;
            this.lwDatCho.UseCompatibleStateImageBehavior = false;
            this.lwDatCho.View = System.Windows.Forms.View.Details;
            this.lwDatCho.SelectedIndexChanged += new System.EventHandler(this.lwDatCho_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số ghế";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giờ check in";
            this.columnHeader2.Width = 53;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giờ check out";
            this.columnHeader3.Width = 59;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số tiền";
            this.columnHeader5.Width = 52;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Loại Phương tiện";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Khởi hành";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Đến";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số điện thoại";
            this.columnHeader8.Width = 0;
            // 
            // lwChoNgoi
            // 
            this.lwChoNgoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwChoNgoi.HideSelection = false;
            this.lwChoNgoi.LargeImageList = this.imgGhe;
            this.lwChoNgoi.Location = new System.Drawing.Point(12, 66);
            this.lwChoNgoi.Margin = new System.Windows.Forms.Padding(2);
            this.lwChoNgoi.MultiSelect = false;
            this.lwChoNgoi.Name = "lwChoNgoi";
            this.lwChoNgoi.Size = new System.Drawing.Size(231, 291);
            this.lwChoNgoi.TabIndex = 17;
            this.lwChoNgoi.UseCompatibleStateImageBehavior = false;
            this.lwChoNgoi.SelectedIndexChanged += new System.EventHandler(this.lwChoNgoi_SelectedIndexChanged);
            // 
            // imgGhe
            // 
            this.imgGhe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgGhe.ImageStream")));
            this.imgGhe.TransparentColor = System.Drawing.Color.Transparent;
            this.imgGhe.Images.SetKeyName(0, "42531-high-speed-train-icon.png");
            this.imgGhe.Images.SetKeyName(1, "hippie-male-icon.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThue_Tra);
            this.groupBox1.Controls.Add(this.btnRest);
            this.groupBox1.Location = new System.Drawing.Point(11, 359);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(231, 48);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnThue_Tra
            // 
            this.btnThue_Tra.BackColor = System.Drawing.Color.White;
            this.btnThue_Tra.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThue_Tra.Location = new System.Drawing.Point(125, 14);
            this.btnThue_Tra.Margin = new System.Windows.Forms.Padding(2);
            this.btnThue_Tra.Name = "btnThue_Tra";
            this.btnThue_Tra.Size = new System.Drawing.Size(92, 27);
            this.btnThue_Tra.TabIndex = 1;
            this.btnThue_Tra.Text = "Đặt &chỗ";
            this.btnThue_Tra.UseVisualStyleBackColor = false;
            this.btnThue_Tra.Click += new System.EventHandler(this.btnThue_Tra_Click);
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.White;
            this.btnRest.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.Location = new System.Drawing.Point(11, 14);
            this.btnRest.Margin = new System.Windows.Forms.Padding(2);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(91, 27);
            this.btnRest.TabIndex = 0;
            this.btnRest.Text = "Reset";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // FormPhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 415);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPhuongTien";
            this.Text = "Book vé phương tiện du lịch";
            this.Load += new System.EventHandler(this.FormPhuongTien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ListView lwDatCho;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lwChoNgoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThue_Tra;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.ImageList imgGhe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboNoiDen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNoiKhoiHanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPhuongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}