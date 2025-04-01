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
    public partial class FormHotels : Form
    {
        ListViewItem Phong, PhongThue;

        public FormHotels()
        {
            InitializeComponent();
        }

        private void FormHotels_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                ListViewItem item = new ListViewItem("Phòng " + i.ToString("00"));
                item.ImageIndex = 1;
                lwPhong.Items.Add(item);
            }
        }

        private void BatTatTT(bool temp)
        {
            cboTenHotel.Enabled = temp;
            cboDiaChi.Enabled = temp;
            txtSoDienThoai.Enabled = temp;
        }

        private void LoadData(ListViewItem item)
        {
            cboTenHotel.Text = item.SubItems[5].Text;
            cboDiaChi.Text = item.SubItems[6].Text;
            txtSoDienThoai.Text = item.SubItems[8].Text;
        }

        private void lwThuePhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwThuePhong.FocusedItem != null)
            {
                PhongThue = lwThuePhong.FocusedItem;
                btnThue_Tra.Text = "Trả &phòng";
                LoadData(PhongThue);
                BatTatTT(false);
                if (PhongThue.SubItems[4].Text.Trim() == "")
                {
                    btnThue_Tra.Enabled = true;
                }
                else
                {
                    btnThue_Tra.Enabled = false;
                }
            }
        }

        private void lwPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwPhong.FocusedItem != null)
            {
                Phong = lwPhong.FocusedItem;
                btnThue_Tra.Text = "Thuê &phòng";
                
                if (Phong.ImageIndex == 1)
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

        private bool KiemTraTT()
        {
            if (cboTenHotel.Text.Trim() == "")
            {
                MessageBox.Show("Xin cho biết tên Khách sạn");
                cboTenHotel.SelectAll();
                cboTenHotel.Focus();
                return false;
            }

            if (cboDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Xin cho biết Địa chỉ");
                cboDiaChi.SelectAll();
                cboDiaChi.Focus();
                return false;
            }

            if (txtSoDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Xin cho biết SDT");
                txtSoDienThoai.SelectAll();
                txtSoDienThoai.Focus();
                return false;
            }
            return true;
        }

        private void btnThue_Tra_Click(object sender, EventArgs e)
        {
            if (btnThue_Tra.Text == "Thuê &phòng")
            {
                if (!KiemTraTT()) return;
                PhongThue = new ListViewItem(Phong.SubItems[0].Text);
                PhongThue.SubItems.Add(DateTime.Now.ToShortTimeString());
                PhongThue.SubItems.Add("");
                PhongThue.SubItems.Add("");
                PhongThue.SubItems.Add("");
                PhongThue.SubItems.Add(cboTenHotel.Text);
                PhongThue.SubItems.Add(cboDiaChi.Text);
                PhongThue.SubItems.Add(txtSoDienThoai.Text);
                lwThuePhong.Items.Add(PhongThue);
                btnThue_Tra.Enabled = false;
                Phong.ImageIndex = 0;
            }
            else
            {
                
                PhongThue.SubItems[2].Text = DateTime.Now.ToShortTimeString();
                TimeSpan GioSD = DateTime.Parse(DateTime.Now.ToShortTimeString()) - Convert.ToDateTime(PhongThue.SubItems[1].Text);
                int Gio = GioSD.Hours;
                int Phut = GioSD.Minutes;
                int SoPhut = Gio * 60 + Phut;
                int Ngay = Gio * 24;
                PhongThue.SubItems[3].Text = Ngay.ToString() + " Ngày";
                int ThanhTien = Ngay * 500000;
                PhongThue.SubItems[4].Text = ThanhTien.ToString("#,##0");
                btnThue_Tra.Enabled = true;
                int ViTri = TimPhongTra(lwPhong, PhongThue.SubItems[0].Text);
                lwPhong.Items[ViTri].ImageIndex = 0;
                lwPhong.Items[ViTri].Focused = true;
                lwPhong.Items[ViTri].Selected = true;
                lwPhong_SelectedIndexChanged(sender, null);

            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            cboTenHotel.Text = "";
            cboDiaChi.Text = "";
            txtSoDienThoai.Text = "";

            foreach (ListViewItem Dong in lwPhong.Items)
            {
                Dong.ImageIndex = 1;
            }
            lwThuePhong.Items.Clear();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int TimPhongTra(ListView lw, string SoPhong)
        {
            for (int i = 0; i < lw.Items.Count; i++)
            {
                if (lw.Items[i].SubItems[0].Text == SoPhong) return i;
            }
            return -1;
        }


    }
}
