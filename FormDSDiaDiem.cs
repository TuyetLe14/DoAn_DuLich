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
    public partial class FormDSDiaDiem : Form
    {


        public FormDSDiaDiem()
        {
            InitializeComponent();
        }

        private void _mainContainer_Panel1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void lstDSKhachSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstDSKhachSan.FocusedItem != null)
            {
                txtTenKhanhSan.Text = lstDSKhachSan.FocusedItem.SubItems[0].Text;
                txtDiaChi.Text= lstDSKhachSan.FocusedItem.SubItems[1].Text;
                txtDienThoai.Text = lstDSKhachSan.FocusedItem.SubItems[2].Text;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lwThamQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lwThamQuan.FocusedItem != null)
            {
                txtTenDiemDen.Text = lwThamQuan.FocusedItem.SubItems[1].Text;
                cboNoiDen.Text = lwThamQuan.FocusedItem.SubItems[2].Text;
            }
        }
    }
}
