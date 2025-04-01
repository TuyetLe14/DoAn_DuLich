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
    public partial class FormGioiThieu : Form
    {
        string ThuMucHinh = Application.StartupPath;


        public FormGioiThieu()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboQuocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboQuocGia.Text == "Anh Quốc")
            {
                cboTenDiaDiem.Items.Clear();
                cboTenDiaDiem.Items.Add("Xứ Wales");
                cboTenDiaDiem.Items.Add("Tháp Bigben");
                cboTenDiaDiem.Items.Add("Phố Baker");
                txtThanhpho.Text = "Luân Đôn";
                picDiaDiem.Image = Image.FromFile(ThuMucHinh + "Anh.jpg");
            }

            if (cboQuocGia.Text == "DuBai")
            {
                cboTenDiaDiem.Items.Clear();
                cboTenDiaDiem.Items.Add("Tòa nhà Burj Khalifa");
                cboTenDiaDiem.Items.Add("Trung tâm thương mại Dubai");
                cboTenDiaDiem.Items.Add("Bến du thuyền Dubai Marina");
                cboTenDiaDiem.Items.Add("Khu trượt tuyết Dubai (Ski Dubai)");
                cboTenDiaDiem.Items.Add("Bảo tàng Dubai");
                txtThanhpho.Text = "United Arab Emirates";
                picDiaDiem.Image = Image.FromFile(ThuMucHinh + "DuBai.jpg");
            }

            if (cboQuocGia.Text == "Nhật")
            {
                cboTenDiaDiem.Items.Clear();
                cboTenDiaDiem.Items.Add("Công viên khỉ Jigoku Dani");
                cboTenDiaDiem.Items.Add("Tháp Tokyo Tower");
                cboTenDiaDiem.Items.Add("Lâu đài Himeji");
                txtThanhpho.Text = "Tokyo";
                picDiaDiem.Image = Image.FromFile(ThuMucHinh + "NhatBan.jpg");
            }

            if (cboQuocGia.Text == "Hàn Quốc")
            {
                cboTenDiaDiem.Items.Clear();
                cboTenDiaDiem.Items.Add("Cung điện Gyeongbokgung");
                cboTenDiaDiem.Items.Add("Khu làng cổ Bukcheon Hanok");
                cboTenDiaDiem.Items.Add("Chợ Namdaemun");
                txtThanhpho.Text = "Seoul";
                picDiaDiem.Image = Image.FromFile(ThuMucHinh + "HanQuoc.jpg");
            }

            if (cboQuocGia.Text == "Ý")
            {
                cboTenDiaDiem.Items.Clear();
                cboTenDiaDiem.Items.Add("Tháp nghiêng Pisa");
                cboTenDiaDiem.Items.Add("Đấu trường La Mã Colosseum");
                cboTenDiaDiem.Items.Add("Nhà thờ Florence Cathedral");
                txtThanhpho.Text = "Thành Rome";
                picDiaDiem.Image = Image.FromFile(ThuMucHinh + "Italia.jpg");
            }

            if (cboQuocGia.Text == "USA")
            {
                cboTenDiaDiem.Items.Clear();
                cboTenDiaDiem.Items.Add("California");
                cboTenDiaDiem.Items.Add("New York");
                cboTenDiaDiem.Items.Add("Arizona");
                txtThanhpho.Text = "Washington D.C";
                picDiaDiem.Image = Image.FromFile(ThuMucHinh + "My.jpg");
            }

            if (cboQuocGia.Text == "Trung Quốc")
            {
                cboTenDiaDiem.Items.Clear();
                cboTenDiaDiem.Items.Add("Tử Cấm Thành");
                cboTenDiaDiem.Items.Add("Vạn Lý Trường Thành");
                cboTenDiaDiem.Items.Add("Bến Thượng Hải");
                txtThanhpho.Text = "Bắc Kinh";
                picDiaDiem.Image = Image.FromFile(ThuMucHinh + "TrungQuoc.jpg");
            }

            if (cboQuocGia.Text == "Phiplipin")
            {
                cboTenDiaDiem.Items.Clear();
                cboTenDiaDiem.Items.Add("Bãi biển Borocay");
                cboTenDiaDiem.Items.Add("Suối nước nóng Ashin");
                cboTenDiaDiem.Items.Add("Đảo Palawan");
                txtThanhpho.Text = "Manila";
                picDiaDiem.Image = Image.FromFile(ThuMucHinh + "Philippines.jpg");
            }

            if (cboQuocGia.Text == "Thái Lan")
            {
                cboTenDiaDiem.Items.Clear();
                cboTenDiaDiem.Items.Add("Grand Palace");
                cboTenDiaDiem.Items.Add("Chùa Phật Ngọc ");
                cboTenDiaDiem.Items.Add("Cung điện Vimanmek");
                txtThanhpho.Text = "Băng Cốc";
                picDiaDiem.Image = Image.FromFile(ThuMucHinh + "ThaiLan.jpg");
            }

            if (cboQuocGia.Text == "Pháp")
            {
                cboTenDiaDiem.Items.Clear();
                cboTenDiaDiem.Items.Add("Đấu trường La Mã Nimes Arena");
                cboTenDiaDiem.Items.Add("Cung điện Versailles");
                cboTenDiaDiem.Items.Add("Chiến trường Chiến tranh thế giới thứ nhất");
                txtThanhpho.Text = "Thủ đô ánh sáng Paris";
                picDiaDiem.Image = Image.FromFile(ThuMucHinh + "Phap.jpg");
            }

            if (cboQuocGia.Text == "Nga")
            {
                cboTenDiaDiem.Items.Clear();
                cboTenDiaDiem.Items.Add("Thánh đường Saint Basils");
                cboTenDiaDiem.Items.Add("Quảng trường Đỏ");
                cboTenDiaDiem.Items.Add("Bảo tàng Hermitage");
                txtThanhpho.Text = "Moscow";
                picDiaDiem.Image = Image.FromFile(ThuMucHinh + "Nga.jpg");
            }
        }

        private void FormGioiThieu_Load(object sender, EventArgs e)
        {
            cboQuocGia.Items.Add("Anh Quốc");
            cboQuocGia.Items.Add("DuBai");
            cboQuocGia.Items.Add("Hàn Quốc");
            cboQuocGia.Items.Add("Ý");
            cboQuocGia.Items.Add("Nhật");

            cboQuocGia.Items.Add("USA");
            cboQuocGia.Items.Add("Nga");
            cboQuocGia.Items.Add("Pháp");
            cboQuocGia.Items.Add("Phiplipin");
            cboQuocGia.Items.Add("Thái Lan");
            cboQuocGia.Items.Add("Trung Quốc");

            ThuMucHinh = ThuMucHinh.Substring(0, ThuMucHinh.LastIndexOf("Bin", StringComparison.OrdinalIgnoreCase)) + @"HinhDL\";
        }
    }
}
