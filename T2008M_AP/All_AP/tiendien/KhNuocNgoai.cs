using System;
using System.Collections.Generic;
namespace T2008M_AP.All_AP.tiendien
{
    public class KhNuocNgoai : KhachHang
    {
        public float ThanhTien;

        public string QuocTich;

        public string QuocTich1
        {
            get => QuocTich;
            set => QuocTich = value;
        }

        //overide Khach Hang
        public override void NhapXuat()
        {
            Console.WriteLine("Moi ban nhap ten khach hang: ");
            HoTen1 = Console.ReadLine();
            Console.WriteLine("Moi ban nhap ten quoc tich: ");
            QuocTich1 = Console.ReadLine();
            Console.WriteLine("Moi ban nhap ma khach hang: ");
            MaKh1 = Console.ReadLine();
            Console.WriteLine("Moi ban nhap ngay ra hoa do: ");
            Nrhd1 = Console.ReadLine();
            Console.WriteLine("Moi ban nhap so luong: ");
            SoLuong1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("THONG TIN KHACH HANG:");
            Console.WriteLine("Ten: "+HoTen1+", ma khach hang: "+MaKh1+", ngay ra hoa don: "+Nrhd1+", so luong: "+SoLuong1);        }

        public override void HoaDon()
        {
            ThanhTien = SoLuong1 * 2000;
            Console.WriteLine("Hoa don cua: "+HoTen1+" la: "+ThanhTien);
        }
    }
}