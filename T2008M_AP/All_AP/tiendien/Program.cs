using System;
using System.Collections.Generic;

namespace T2008M_AP.All_AP.tiendien
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Viet Nam
            List<KhVietNam> danhsachVN = new List<KhVietNam>();
            KhVietNam khVietNam = new KhVietNam();
            khVietNam.NhapXuat();
            danhsachVN.Add(khVietNam);
            khVietNam.HoaDon();
            KhVietNam khVietNam1 = new KhVietNam();
            khVietNam1.NhapXuat();
            danhsachVN.Add(khVietNam1);
            khVietNam1.HoaDon();
            //Tong so luong viet nam
            int tongSoLuongVn = 0;
            foreach (var VARIABLE in danhsachVN)
            {
                tongSoLuongVn += VARIABLE.SoLuong1;
            }
            Console.WriteLine("Tong so luong cua khach hang Viet Nam la: "+tongSoLuongVn);
            
            //Nuoc ngoai
            List<KhNuocNgoai> danhsachNN = new List<KhNuocNgoai>();
            KhNuocNgoai khNuocNgoai = new KhNuocNgoai();
            khNuocNgoai.NhapXuat();
            danhsachNN.Add(khNuocNgoai);
            khNuocNgoai.HoaDon();
            KhNuocNgoai khNuocNgoai1 = new KhNuocNgoai();
            khNuocNgoai1.NhapXuat();
            danhsachNN.Add(khNuocNgoai1);
            khNuocNgoai1.HoaDon();
            //Tong so luong nuoc ngoai
            int tongSoLuongNN = 0;
            foreach (var VARIABLE in danhsachNN)
            {
                tongSoLuongNN += VARIABLE.SoLuong1;
            }
            Console.WriteLine("Tong so luong cua khach hang Nuoc Ngoai la: "+tongSoLuongNN);
        }
    }
}