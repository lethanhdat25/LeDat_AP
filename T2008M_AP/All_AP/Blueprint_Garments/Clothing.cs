using System.Collections.Generic;

namespace T2008M_AP.All_AP.Blueprint_Garments
{
    public abstract class Clothing
    {
        public List<Areas> SaleArea=new List<Areas>();
        public List<string> Collection=new List<string>();
        public float sale;
        public int qty;

        public float Sale
        {
            get => sale;
            set => sale = value;
        }

        public int Qty
        {
            get => qty;
            set => qty = value;
        }

        public List<Areas> SaleArea1 => SaleArea;

        public List<string> Collection1 => Collection;

        public abstract void Sales();
        public abstract void Materials(string a);
        public abstract void CommonWear();
    }
}