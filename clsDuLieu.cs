using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_DuLich_LTC085A0003_LTC085A0004
{
    public class clsDuLieu
    {
        clsKhachHang nv;

        public ArrayList Doc(string sFileName)
        {
            ArrayList arrlst = new ArrayList();
            StreamReader TapTinDoc;
            FileStream TapTinTao;
            string Dong;
            int viTriBD = 0, ViTriTimThay = -1;
            try
            {
                if (!File.Exists(sFileName) == true)
                {
                    TapTinTao = File.Create(sFileName);
                    TapTinTao.Close();
                }
                TapTinDoc = File.OpenText(sFileName);
                while (true)
                {
                    nv = new clsKhachHang();
                    Dong = TapTinDoc.ReadLine();
                    if (Dong == null)
                    {
                        break;
                    }
                    else
                    {
                        viTriBD = 0;
                        string[] MauTin = new string[11];
                        for (int i = 0; i < 6; i++)
                        {
                            ViTriTimThay = Dong.IndexOf(";", viTriBD);
                            MauTin[i] = Dong.Substring(viTriBD, ViTriTimThay - viTriBD);

                            viTriBD = ViTriTimThay + 1;
                        }
                        MauTin[6] = Dong.Substring(ViTriTimThay + 1);
                        nv.MaKH = MauTin[0];
                        nv.MaQG = MauTin[1];
                        nv.HoTen = MauTin[2];
                        nv.Phai = bool.Parse(MauTin[3]);
                        nv.DiaChi = MauTin[4];
                        nv.DienThoai = MauTin[5];
                        nv.Hinh = MauTin[6];
                        arrlst.Add(nv);
                    }
                }
                TapTinDoc.Close();
                return arrlst;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể đọc tập tin dữ liệu");
                return null;
            }
        }
        public void Ghi(string sFileName, TreeView tw)
        {
            StreamWriter TapTinGhi;
            FileStream TapTinTao;
            try
            {
                TapTinTao = File.Create(sFileName);
                TapTinTao.Close();
                TapTinGhi = File.AppendText(sFileName);
                string MauTin = "";
                foreach (TreeNode NutCha in tw.Nodes)
                {
                    foreach (TreeNode NutCon in NutCha.Nodes)
                    {
                        nv = (clsKhachHang)NutCon.Tag;
                        MauTin = nv.MaKH + ";" + nv.MaQG + ";" +
                        nv.HoTen + ";" +
                        nv.Phai + ";" + nv.DiaChi + ";" + nv.DienThoai + ";" + nv.Hinh;
                        TapTinGhi.WriteLine(MauTin);
                    }
                }
                TapTinGhi.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lưu tập tin");
            }
        }
    }
}
