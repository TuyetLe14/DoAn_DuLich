namespace DoAn_DuLich_LTC085A0003_LTC085A0004
{
    partial class FormGioiThieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGioiThieu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboQuocGia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThanhpho = new System.Windows.Forms.TextBox();
            this.picDiaDiem = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboTenDiaDiem = new System.Windows.Forms.ComboBox();
            this.diagOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picDiaDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁC ĐỊA ĐIỂM TRÊN THẾ GIỚI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên địa điểm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quốc gia:";
            // 
            // cboQuocGia
            // 
            this.cboQuocGia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuocGia.FormattingEnabled = true;
            this.cboQuocGia.Location = new System.Drawing.Point(90, 34);
            this.cboQuocGia.Margin = new System.Windows.Forms.Padding(2);
            this.cboQuocGia.Name = "cboQuocGia";
            this.cboQuocGia.Size = new System.Drawing.Size(161, 23);
            this.cboQuocGia.TabIndex = 32;
            this.cboQuocGia.SelectedIndexChanged += new System.EventHandler(this.cboQuocGia_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Thành phố:";
            // 
            // txtThanhpho
            // 
            this.txtThanhpho.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhpho.Location = new System.Drawing.Point(90, 63);
            this.txtThanhpho.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhpho.Name = "txtThanhpho";
            this.txtThanhpho.Size = new System.Drawing.Size(161, 22);
            this.txtThanhpho.TabIndex = 34;
            // 
            // picDiaDiem
            // 
            this.picDiaDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDiaDiem.Location = new System.Drawing.Point(340, 3);
            this.picDiaDiem.Margin = new System.Windows.Forms.Padding(2);
            this.picDiaDiem.Name = "picDiaDiem";
            this.picDiaDiem.Size = new System.Drawing.Size(184, 173);
            this.picDiaDiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiaDiem.TabIndex = 0;
            this.picDiaDiem.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 64);
            this.label5.TabIndex = 36;
            this.label5.Text = "  CHÚC QUÝ KHÁCH HÀNG\r\nCÓ MỘT CHUYẾN ĐI VUI VẺ!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 195);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(319, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnQuayLai);
            this.panel2.Location = new System.Drawing.Point(340, 198);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 63);
            this.panel2.TabIndex = 39;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuayLai.Location = new System.Drawing.Point(5, 21);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(177, 27);
            this.btnQuayLai.TabIndex = 37;
            this.btnQuayLai.Text = "Quay lại trang chủ ";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboTenDiaDiem);
            this.panel3.Controls.Add(this.picDiaDiem);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtThanhpho);
            this.panel3.Controls.Add(this.cboQuocGia);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 276);
            this.panel3.TabIndex = 40;
            // 
            // cboTenDiaDiem
            // 
            this.cboTenDiaDiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenDiaDiem.FormattingEnabled = true;
            this.cboTenDiaDiem.Location = new System.Drawing.Point(90, 3);
            this.cboTenDiaDiem.Name = "cboTenDiaDiem";
            this.cboTenDiaDiem.Size = new System.Drawing.Size(161, 23);
            this.cboTenDiaDiem.TabIndex = 40;
            // 
            // diagOpen
            // 
            this.diagOpen.FileName = "openFileDialog1";
            // 
            // FormGioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 338);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGioiThieu";
            this.Text = "FormGioiThieu";
            this.Load += new System.EventHandler(this.FormGioiThieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDiaDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboQuocGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThanhpho;
        private System.Windows.Forms.PictureBox picDiaDiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboTenDiaDiem;
        private System.Windows.Forms.OpenFileDialog diagOpen;
    }
}