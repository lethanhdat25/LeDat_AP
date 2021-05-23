using System;

namespace T2008M_AP.All_AP.ss1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int id = 0;
            Console.WriteLine("moi ban nhap ten:");
            var name=Console.ReadLine();
            
            Console.WriteLine("moi ban nhap so luong");
            int qty=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("moi ban nhap ten anh");
            var image=Console.ReadLine();
            
            Console.WriteLine("moi ban nhap gia tien");
            var giatien=Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("moi ban nhap desc");
            var descs=Console.ReadLine();
            Product product = new Product(id, qty, name, descs, image, giatien);
            
            product.gallery.Add(product.name);
            product.GetInfo();
            Console.WriteLine((product.CheckQty(product.qty))?"con hang":"het hang");
            product.AddImage(product.image);

            Fashion fs = new Fashion();
            fs.kichco = "M";
            fs.mausac = "mau do";
            fs.CheckQty(product.qty);

            Diamon diamon = new Diamon();
            diamon.cara = 44;
            diamon.CheckQty(diamon.cara);

            Cart cart = new Cart();
            cart.customer = "dat";
            cart.city = "hhh";
            cart.country = "VietNam";
            cart.AddProduct(product);
            cart.GrandTotal();
        }

    }
}