using System;

namespace T2008M_AP.All_AP.ss1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product product = new Product();
            product.id = 0;
            product.name = "sp1";
            product.price = 123.23;
            product.qty = 0;
            product.image = "fgscf";
            product.desc = "qdfa";
            product.gallery.Add("anh1");
            product.gallery.Add("anh2");
            product.GetInfo();
            Console.WriteLine((product.CheckQty(product.qty))?"con hang":"het hang");
            Console.WriteLine("Nhap ten anh muon them:");
            var a=Console.ReadLine();
            product.AddImage(a);
        }

    }
}