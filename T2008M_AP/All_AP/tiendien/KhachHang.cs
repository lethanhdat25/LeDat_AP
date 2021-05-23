namespace T2008M_AP.All_AP.tiendien
{
    public abstract class KhachHang
    {
        public string MaKh,HoTen,Nrhd,DonGia;
        public int SoLuong;
        public string MaKh1
        {
            get => MaKh;
            set => MaKh = value;
        }

        public string HoTen1
        {
            get => HoTen;
            set => HoTen = value;
        }

        public string Nrhd1
        {
            get => Nrhd;
            set => Nrhd = value;
        }

        public int SoLuong1
        {
            get => SoLuong;
            set => SoLuong = value;
        }

        public string DonGia1
        {
            get => DonGia;
            set => DonGia = value;
        }

        public abstract void NhapXuat();
        public abstract void HoaDon();

    }
}