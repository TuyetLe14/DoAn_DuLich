namespace DoAn_DuLich_LTC085A0003_LTC085A0004
{
    partial class FormHotels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHotels));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDiaChi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTenHotel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.lwThuePhong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwPhong = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoDienThoai);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.cboDiaChi);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cboTenHotel);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip);
            this.splitContainer1.Panel2.Controls.Add(this.lwThuePhong);
            this.splitContainer1.Panel2.Controls.Add(this.lwPhong);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(755, 412);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(21, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 222);
            this.label5.TabIndex = 30;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(93, 120);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(94, 20);
            this.txtSoDienThoai.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số điện thoại:";
            // 
            // cboDiaChi
            // 
            this.cboDiaChi.FormattingEnabled = true;
            this.cboDiaChi.Items.AddRange(new object[] {
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
            this.cboDiaChi.Location = new System.Drawing.Point(65, 71);
            this.cboDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.cboDiaChi.Name = "cboDiaChi";
            this.cboDiaChi.Size = new System.Drawing.Size(122, 21);
            this.cboDiaChi.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Địa chỉ:";
            // 
            // cboTenHotel
            // 
            this.cboTenHotel.FormattingEnabled = true;
            this.cboTenHotel.Items.AddRange(new object[] {
            "Lotte Hà Nội",
            "Sofitel Metropole",
            "Khách sạn Hà Nội Daewoo",
            "Nikko",
            "Khách sạn Moevenpick",
            "Melia Hà Nội",
            "Hilton Opera",
            "Sofitel Plaza",
            "De L’Opera",
            "Intercontinental Hanoi Westlake"});
            this.cboTenHotel.Location = new System.Drawing.Point(65, 32);
            this.cboTenHotel.Margin = new System.Windows.Forms.Padding(2);
            this.cboTenHotel.Name = "cboTenHotel";
            this.cboTenHotel.Size = new System.Drawing.Size(122, 21);
            this.cboTenHotel.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên hotel:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "BOOK HOTEL  ";
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
            this.menuStrip.Size = new System.Drawing.Size(557, 25);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(56, 23);
            this.mnuThoat.Text = "&Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // lwThuePhong
            // 
            this.lwThuePhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lwThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwThuePhong.FullRowSelect = true;
            this.lwThuePhong.GridLines = true;
            this.lwThuePhong.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lwThuePhong.HideSelection = false;
            this.lwThuePhong.Location = new System.Drawing.Point(237, 62);
            this.lwThuePhong.Margin = new System.Windows.Forms.Padding(2);
            this.lwThuePhong.MultiSelect = false;
            this.lwThuePhong.Name = "lwThuePhong";
            this.lwThuePhong.Size = new System.Drawing.Size(313, 343);
            this.lwThuePhong.TabIndex = 13;
            this.lwThuePhong.UseCompatibleStateImageBehavior = false;
            this.lwThuePhong.View = System.Windows.Forms.View.Details;
            this.lwThuePhong.SelectedIndexChanged += new System.EventHandler(this.lwThuePhong_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số phòng";
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
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng thời gian";
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số tiền";
            this.columnHeader5.Width = 52;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên Hotel";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Địa Chỉ";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "SĐT";
            this.columnHeader8.Width = 0;
            // 
            // lwPhong
            // 
            this.lwPhong.HideSelection = false;
            this.lwPhong.LargeImageList = this.imageList1;
            this.lwPhong.Location = new System.Drawing.Point(3, 62);
            this.lwPhong.Margin = new System.Windows.Forms.Padding(2);
            this.lwPhong.MultiSelect = false;
            this.lwPhong.Name = "lwPhong";
            this.lwPhong.Size = new System.Drawing.Size(231, 291);
            this.lwPhong.TabIndex = 12;
            this.lwPhong.UseCompatibleStateImageBehavior = false;
            this.lwPhong.SelectedIndexChanged += new System.EventHandler(this.lwPhong_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DaCoNguoiThue");
            this.imageList1.Images.SetKeyName(1, "Conphong");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThue_Tra);
            this.groupBox1.Controls.Add(this.btnRest);
            this.groupBox1.Location = new System.Drawing.Point(3, 356);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(231, 48);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btnThue_Tra
            // 
            this.btnThue_Tra.BackColor = System.Drawing.Color.White;
            this.btnThue_Tra.Location = new System.Drawing.Point(125, 14);
            this.btnThue_Tra.Margin = new System.Windows.Forms.Padding(2);
            this.btnThue_Tra.Name = "btnThue_Tra";
            this.btnThue_Tra.Size = new System.Drawing.Size(92, 27);
            this.btnThue_Tra.TabIndex = 1;
            this.btnThue_Tra.Text = "Thuê &phòng";
            this.btnThue_Tra.UseVisualStyleBackColor = false;
            this.btnThue_Tra.Click += new System.EventHandler(this.btnThue_Tra_Click);
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.White;
            this.btnRest.Location = new System.Drawing.Point(4, 14);
            this.btnRest.Margin = new System.Windows.Forms.Padding(2);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(91, 27);
            this.btnRest.TabIndex = 0;
            this.btnRest.Text = "Reset";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // FormHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(755, 412);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHotels";
            this.Text = "FormHotels";
            this.Load += new System.EventHandler(this.FormHotels_Load);
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
        private System.Windows.Forms.ListView lwThuePhong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lwPhong;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThue_Tra;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.ComboBox cboDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTenHotel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}