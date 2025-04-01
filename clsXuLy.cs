using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_DuLich_LTC085A0003_LTC085A0004
{
    public class clsXuLy
    {
        clsDuLieu dl = new clsDuLieu();
        public void DocDuLieu(string TenFile, TreeView tw, ArrayList arr)
        {
            arr = dl.Doc(TenFile);
            foreach (TreeNode NutPB in tw.Nodes)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    clsKhachHang nv = (clsKhachHang)arr[i];
                    //NutPB.Text=PB.
                    if (NutPB.Tag.ToString() == nv.MaQG)
                    {
                        TreeNode NutNV = new TreeNode();
                        NutNV.Text = nv.HoTen + " (" + nv.MaKH + ")";
                        NutNV.Tag = nv;
                        NutPB.Nodes.Add(NutNV);
                    }
                }
            }
        }

        public void GhiDuLieu(string TenFile, TreeView tw)
        {
            dl.Ghi(TenFile, tw);
        }

        public bool KtMaNV(string Ma, TreeView tw)
        {
            clsKhachHang nv;
            foreach (TreeNode NutCha in tw.Nodes)
            {
                foreach (TreeNode NutCon in NutCha.Nodes)
                {
                    nv = (clsKhachHang)NutCon.Tag;
                    if (nv.MaKH.ToUpper() == Ma.ToUpper())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int TimVitri(string Ma, TreeView tw)
        {
            clsKhachHang nv;
            foreach (TreeNode NutCha in tw.Nodes)
            {
                foreach (TreeNode NutCon in NutCha.Nodes)
                {
                    nv = (clsKhachHang)NutCon.Tag;
                    if (nv.MaKH.ToUpper() == Ma.ToUpper())
                    {
                        return NutCon.Index; ;
                    }
                }
            }
            return -1;
        }
        public string Space(int n)
        {
            string KhoangTrang = "";
            for (int i = 1; i <= n; i++) KhoangTrang += " ";
            return KhoangTrang;
        }
        public string ChuanChuoi(string Chuoi)
        {
            string KTuTim;
            Chuoi = Chuoi.Trim().ToLower();
            int ViTri = Chuoi.IndexOf(Space(2));
            while (ViTri != -1)
            {
                Chuoi = Chuoi.Replace(Space(2), Space(1));
                ViTri = Chuoi.IndexOf(Space(2));
            }
            KTuTim = Chuoi.Substring(0, 1).ToUpper();
            Chuoi = Chuoi.Remove(0, 1);
            Chuoi = Chuoi.Insert(0, KTuTim);
            for (int i = 2; i < Chuoi.Length; i++)
            {
                if (Chuoi[i - 1].ToString() == Space(1) || Chuoi[i - 1].ToString() == "." || char.IsDigit(Chuoi[i - 1]))
                {
                    KTuTim = Chuoi.Substring(i, 1).ToUpper();
                    Chuoi = Chuoi.Remove(i, 1);
                    Chuoi = Chuoi.Insert(i, KTuTim);
                }
            }
            return Chuoi;
        }


    }
}
