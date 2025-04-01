using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_DuLich_LTC085A0003_LTC085A0004
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDatChoPT_Click(object sender, EventArgs e)
        {
            FormPhuongTien frm = new FormPhuongTien();

            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnDoanKhach_Click(object sender, EventArgs e)
        {
            FormQuanLyHanhKhach frm = new FormQuanLyHanhKhach();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnDiaDiem_Click(object sender, EventArgs e)
        {
            FormDSDiaDiem frm = new FormDSDiaDiem();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            FormHotels frm = new FormHotels();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnGioithieu_Click(object sender, EventArgs e)
        {
            FormGioiThieu frm = new FormGioiThieu();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
