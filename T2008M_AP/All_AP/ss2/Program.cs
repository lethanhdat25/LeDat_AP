using System;

namespace T2008M_AP.All_AP.ss2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product product = new Product();
            product.ProducName = "dat";
            Console.WriteLine(product.ProducName);
            product.gallery.Add("image1.png"); // dang su dung indexers
            product.gallery.Add("image2.png"); // dang su dung indexers
            product[1] = "image3.png";// set
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(product[i]); //get
            }
        }
    }
}