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
    public partial class FormPhuongTien : Form
    {
        ListViewItem Ghe, GheDat;

        public FormPhuongTien()
        {
            InitializeComponent();
        }

        private void BatTatTT(bool temp)
        {
            cboPhuongTien.Enabled = temp;
            cboNoiKhoiHanh.Enabled = temp;
            cboNoiDen.Enabled = temp;
            txtSoDienThoai.Enabled = temp;
        }

        private void LoadData(ListViewItem item)
        {
            cboPhuongTien.Text = item.SubItems[5].Text;
            cboNoiKhoiHanh.Text = item.SubItems[6].Text;
            cboNoiDen.Text = item.SubItems[7].Text;
            txtSoDienThoai.Text = item.SubItems[8].Text;
        }

        private void lwDatCho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwDatCho.FocusedItem != null)
            {
                GheDat = lwDatCho.FocusedItem;
                btnThue_Tra.Text = "Trả &ghế";
                LoadData(GheDat);
                BatTatTT(false);
                if (GheDat.SubItems[4].Text.Trim() == "")//Chưa tính tiền
                {
                    btnThue_Tra.Enabled = true;
                }
                else
                {    
                    btnThue_Tra.Enabled = false;
                }
            }
        }

        private void lwChoNgoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwChoNgoi.FocusedItem != null)
            {
                Ghe = lwChoNgoi.FocusedItem;
                btnThue_Tra.Text = "Đặt &ghế";
                if (Ghe.ImageIndex == 0)
                {
                    BatTatTT(true);
                    btnThue_Tra.Enabled = true;
                }
                else
                {
                    BatTatTT(false);
                    btnThue_Tra.Enabled = false;
                }
            }
        }

        private int TimGheTra(ListView lw, string SoGhe)
        {
            for (int i = 0; i < lw.Items.Count; i++)
            {
                if (lw.Items[i].SubItems[0].Text == SoGhe) return i;
            }
            return -1;
        }

        private bool KiemTraTT()
        {
            if(cboNoiDen.Text == cboNoiKhoiHanh.Text)
            {
                MessageBox.Show("Nơi đến không thể trùng với nơi Khởi hành");
                return false;
            }

            if (cboPhuongTien.Text.Trim() == "")
            {
                MessageBox.Show("Xin cho biết SĐT");
                cboPhuongTien.SelectAll();
                cboPhuongTien.Focus();
                return false;
            }

            if (cboNoiKhoiHanh.Text.Trim() == "")
            {
                MessageBox.Show("Xin cho biết Nơi khởi hành");
                cboNoiKhoiHanh.SelectAll();
                cboNoiKhoiHanh.Focus();
                return false;
            }

            if (cboNoiDen.Text.Trim() == "")
            {
                MessageBox.Show("Xin cho biết Nơi đến");
                cboNoiDen.SelectAll();
                cboNoiDen.Focus();
                return false;
            }

            if (txtSoDienThoai.Text.Trim() =="")
            {
                MessageBox.Show("Xin cho biết SĐT");
                txtSoDienThoai.SelectAll();
                txtSoDienThoai.Focus();
                return false;
            }

            return true;
        }

        private void btnThue_Tra_Click(object sender, EventArgs e)
        {
            if (btnThue_Tra.Text == "Đặt &ghế")
            {
                if (!KiemTraTT()) return;
                GheDat = new ListViewItem(Ghe.SubItems[0].Text);
                GheDat.SubItems.Add(DateTime.Now.ToShortTimeString());
                GheDat.SubItems.Add("");
                GheDat.SubItems.Add("");
                GheDat.SubItems.Add("");
                GheDat.SubItems.Add(cboPhuongTien.Text);
                GheDat.SubItems.Add(cboNoiKhoiHanh.Text);
                GheDat.SubItems.Add(cboNoiDen.Text);
                GheDat.SubItems.Add(txtSoDienThoai.Text);
                lwDatCho.Items.Add(GheDat);
                btnThue_Tra.Enabled = false;
                Ghe.ImageIndex = 1;
            }
            else
            {

                GheDat.SubItems[2].Text = DateTime.Now.ToShortTimeString();
                TimeSpan GioSD = DateTime.Parse(DateTime.Now.ToShortTimeString()) - Convert.ToDateTime(GheDat.SubItems[1].Text);
                int Gio = GioSD.Hours;
                int Phut = GioSD.Minutes;
                int SoPhut = Gio * 60 + Phut;
       
                GheDat.SubItems[3].Text = Gio.ToString() + " Giờ";
                int TienVe = 350;
                GheDat.SubItems[3].Text = TienVe.ToString("#,##0");
                btnThue_Tra.Enabled = true;
                int ViTri = TimGheTra(lwChoNgoi, GheDat.SubItems[0].Text);
                lwChoNgoi.Items[ViTri].ImageIndex = 0;
                lwChoNgoi.Items[ViTri].Focused = true;
                lwChoNgoi.Items[ViTri].Selected = true;
                lwChoNgoi_SelectedIndexChanged(sender, null);

            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            cboPhuongTien.Text = cboPhuongTien.Items[0].ToString();
            cboNoiDen.Text = cboNoiDen.Items[0].ToString();
            cboNoiKhoiHanh.Text = cboNoiKhoiHanh.Items[0].ToString();
            txtSoDienThoai.Text = "";

            foreach (ListViewItem Dong in lwChoNgoi.Items)
            {
                Dong.ImageIndex = 0;
            }
            lwDatCho.Items.Clear();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPhuongTien_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                ListViewItem item = new ListViewItem("Ghế " + i.ToString("00"));
                item.ImageIndex = 0;
                lwChoNgoi.Items.Add(item);
            }
        }
    }
}
