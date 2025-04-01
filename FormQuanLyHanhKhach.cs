using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_DuLich_LTC085A0003_LTC085A0004
{
    public partial class FormQuanLyHanhKhach : Form
    {
        clsXuLy xl = new clsXuLy();
        clsKhachHang nv = new clsKhachHang();
        string[] QuocGia = { "USA", "USA", "Trung Quốc", "TQ", "Nga", "RU", "Nhật Bản", "JA",
            "Anh Quốc", "AQ" };
        TreeNode NutQG;
        bool Moi = false, ThayDoi = false;
        int ViTriNutCha = -1, ViTriHienTai = -1;
        string strMaQG = "", HinhGoc = "", TapTinHinh = "", ThuMucHinh = Application.StartupPath, TapTinDL = "";
        CultureInfo ci = new CultureInfo("vi-VN");
        ArrayList arrNV = new ArrayList();

        public FormQuanLyHanhKhach()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoDkh(bool Mo)
        {
            txtMaKH.ReadOnly = !Mo;
            txtHoTen.ReadOnly = !Mo;
            
            grpPhai.Enabled = Mo;
            txtDiaChi.ReadOnly = !Mo;

            txtDienThoai.ReadOnly = !Mo;
            picHinh.Enabled = Mo;
            grpLuu.Enabled = Mo;
            grpHinh.Enabled = Mo;

            twDSKH.Enabled = !Mo;
            grpTSX.Enabled = !Mo;
        }

        private void XoaND()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            picHinh.Image = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (twDSKH.SelectedNode.Parent != null)
            {
                if (MessageBox.Show("Bạn có thật sự muốn loại bỏ khách hàng này không?", "Cảnh báo: xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    twDSKH.Nodes.Remove(twDSKH.SelectedNode);
                    twDSKH.Focus();
                    ThayDoi = true;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Moi = false;
            MoDkh(true);
            txtMaKH.ReadOnly = true;
            txtHoTen.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Moi = true;
            MoDkh(true);
            XoaND();
            txtMaKH.Focus();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            MoDkh(false);
            twDSKH.Focus();
            twDSKH_AfterSelect(sender, null);
            Moi = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KtThongTin()) return;
            if (TapTinHinh != "")
            {
                if (!File.Exists(ThuMucHinh + TapTinHinh))
                {
                    File.Copy(HinhGoc, ThuMucHinh + TapTinHinh);
                }
            }
            if (Moi)
            {
                if (xl.KtMaNV(txtMaKH.Text, twDSKH))
                {
                    MessageBox.Show("Mã khách hàng này đã có, xin cho mã số khác", "Kiểm tra mã khách hàng");
                    txtMaKH.SelectAll();
                    txtMaKH.Focus();
                    return;
                }
                nv = new clsKhachHang();
                CapNhatNV();
                TreeNode Nut = new TreeNode();
                Nut.Text = nv.HoTen + " (" + nv.MaKH + ") ";
                Nut.Tag = nv;
                if (twDSKH.SelectedNode.Parent == null)
                {
                    twDSKH.SelectedNode.Nodes.Add(Nut);
                }
                else
                {
                    twDSKH.SelectedNode.Parent.Nodes.Add(Nut);
                }
            }
            else //Trường hợp sửa
            {
                CapNhatNV();
                twDSKH.SelectedNode.Text = nv.HoTen + " (" + nv.MaKH + ")";
                twDSKH.SelectedNode.Tag = nv;
                twDSKH.SelectedNode.Tag = nv;
                twDSKH.Refresh();
            }
            MoDkh(false);
            Moi = false;
            ThayDoi = true;
            twDSKH.Focus();
            twDSKH.CollapseAll();
            twDSKH.SelectedNode = twDSKH.Nodes[ViTriNutCha].Nodes[xl.TimVitri(nv.MaKH, twDSKH)];
        }

        private void FormQuanLyHanhKhach_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            TapTinDL = ThuMucHinh.Substring(0, ThuMucHinh.LastIndexOf("Bin", StringComparison.OrdinalIgnoreCase)) + @"DuLieu.txt";
            ThuMucHinh = ThuMucHinh.Substring(0, ThuMucHinh.LastIndexOf("Bin", StringComparison.OrdinalIgnoreCase)) + @"Hinh\";
            MoDkh(false);

            for (int i = 0; i < QuocGia.GetLength(0); i = i + 2)
            {
                NutQG = new TreeNode();
                NutQG.Text = QuocGia[i];
                NutQG.Tag = QuocGia[i + 1];
                twDSKH.Nodes.Add(NutQG);
            }
            xl.DocDuLieu(TapTinDL, twDSKH, arrNV);
            twDSKH.ExpandAll();
            diagOpen.InitialDirectory = ThuMucHinh;
        }

        private void twDSKH_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (twDSKH.SelectedNode != null)
            {
                if (twDSKH.SelectedNode.Parent == null)
                {
                    ViTriNutCha = twDSKH.SelectedNode.Index;
                    ViTriHienTai = -1;//nút con nhân viên
                    strMaQG = twDSKH.SelectedNode.Tag.ToString();
                    XoaND();
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else
                {
                    ViTriNutCha = twDSKH.SelectedNode.Parent.Index;
                    ViTriHienTai = twDSKH.SelectedNode.Index;
                    strMaQG = twDSKH.SelectedNode.Parent.Tag.ToString();
                    nv = (clsKhachHang)twDSKH.SelectedNode.Tag;
                    txtMaKH.Text = nv.MaKH; 
                    txtHoTen.Text = nv.HoTen;
                    radNam.Checked = nv.Phai;
                    radNu.Checked = !nv.Phai;
                    txtDiaChi.Text = nv.DiaChi;
                    txtDienThoai.Text = nv.DienThoai;
                    TapTinHinh = nv.Hinh;
                    if (TapTinHinh != "")
                    {
                        picHinh.Image = Image.FromFile(ThuMucHinh + TapTinHinh);
                    }
                    else
                    {
                        picHinh.Image = null;
                    }
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
            }
        }

        private void twDSKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (twDSKH.SelectedNode != null)
            {
                TreeNode nHH = twDSKH.SelectedNode;
                if (e.KeyCode == Keys.Enter)
                {
                    if (nHH.Parent == null)
                    {
                        if (nHH.IsExpanded)
                        {
                            nHH.Collapse();
                        }
                        else
                        {
                            nHH.Expand();
                        }
                    }
                }
            }
        }

        private void btnXoaHinh_Click(object sender, EventArgs e)
        {
            if (picHinh.Image != null)
            {
                DialogResult TL = MessageBox.Show("Bạn có thật sự muốn xóa bỏ ảnh của khách hàng này không?", "Cảnh báo: xóa ảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (TL == DialogResult.Yes)
                {
                    picHinh.Image = null;
                    TapTinHinh = "";
                }
            }
            else
            {
                MessageBox.Show("Chưa có hình");
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            if (diagOpen.ShowDialog() == DialogResult.OK)
            {
                HinhGoc = diagOpen.FileName;
                TapTinHinh = HinhGoc.Substring(HinhGoc.LastIndexOf(@"\") + 1);
                picHinh.Image = Image.FromFile(HinhGoc);
            }
        }

        private void FormQuanLyHanhKhach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ThayDoi) xl.GhiDuLieu(TapTinDL, twDSKH);
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Trim() != "")
            {
                txtDiaChi.Text = xl.ChuanChuoi(txtDiaChi.Text);
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ') e.Handled = true;
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim() == "")
            {
                txtHoTen.Text = xl.ChuanChuoi(txtHoTen.Text);
            }
        }

        private void CapNhatNV()
        {
            nv.MaKH = txtMaKH.Text;
            nv.MaQG = strMaQG;
            nv.HoTen = txtHoTen.Text;
            nv.Phai = radNam.Checked;
            nv.DiaChi = txtDiaChi.Text;
            nv.DienThoai = txtDienThoai.Text;
            nv.Hinh = TapTinHinh;
        }

        private bool KtThongTin()
        {
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Xin cho biết mã số", "Kiểm tra thông tin");
                txtMaKH.SelectAll();
                txtMaKH.Focus();
                return false;
            }

            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Xin cho biết họ tên nhân viên", "Kiểm tra thông tin");
                txtHoTen.SelectAll();
                txtHoTen.Focus();
                return false;
            }

            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Xin cho biết địa chỉ của nhân viên", "Kiểm tra thông tin");
                txtDiaChi.SelectAll();
                txtDiaChi.Focus();
                return false;
            }
           
            return true;
        }
    }
}
