using System;
using System.Collections.Generic;

namespace T2008M_AP.All_AP.tiendien
{
    public class KhVietNam : KhachHang
    
    
    {
        //danh sach 
        public List<KhVietNam> DanhSach = new List<KhVietNam>();

        //constructor
        public KhVietNam()
        {
        }
        public float ThanhTien;
        public string DoiTuong;
        //read-write
        public string DoiTuong1
        {
            get => DoiTuong;
            set => DoiTuong = value;
        }

        //overide Khach Hang
        public override void NhapXuat()
        {
            Console.WriteLine("Moi ban nhap ten khach hang: ");
            HoTen1 = Console.ReadLine();
            Console.WriteLine("Moi ban nhap ma khach hang: ");
            MaKh1 = Console.ReadLine();
            Console.WriteLine("Moi ban nhap ngay ra hoa do: ");
            Nrhd1 = Console.ReadLine();
            Console.WriteLine("Moi ban nhap doi tuong khach hang: ");
            DoiTuong1 = Console.ReadLine();
            Console.WriteLine("Moi ban nhap so luong: ");
            SoLuong1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("THONG TIN KHACH HANG:");
            Console.WriteLine("Ten: "+HoTen1+", ma khach hang: "+MaKh1+", ngay ra hoa don: "+Nrhd1+", doi tuong khach hang: "+DoiTuong1+", so luong: "+SoLuong1);
        }
        
        public override void HoaDon()
        {
            if (SoLuong1<=50) ThanhTien = SoLuong1 * 1000;
            else if (SoLuong1>50 && SoLuong1<=100) ThanhTien = (50 * 1000 + (SoLuong1 - 50) * 1200);
            else if (SoLuong1>100 && SoLuong1<=200) ThanhTien = (50 * 1000 + (SoLuong1 - 50) * 1500);
            else if (SoLuong1>200) ThanhTien = (50 * 1000 + (SoLuong1 - 50) * 2000);
            Console.WriteLine("Hoa don cua: "+HoTen1+" la: "+ThanhTien);
        }
    }
}