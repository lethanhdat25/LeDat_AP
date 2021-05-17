using System;
using System.Collections.Generic;
using System.Linq;

namespace T2008M_AP.All_AP.ss1
{
    public class Product
    {
        public int id,qty;
        public string name, desc, image;
        public double price;
        public List<string> gallery = new List<string>();
        public Product()
        {
        }

        public Product(int id, int qty, string name, string desc, string image, float price)
        {
            this.id = id;
            this.qty = qty;
            this.name = name;
            this.desc = desc;
            this.image = image;
            this.price = price;
        }

        public void GetInfo()
        {
           Console.WriteLine(id+name+price+qty+desc+image); 
        }

        public bool CheckQty(int qty)
        {
            return (qty>0)?true:false;
        }

        public void AddImage(string img)
        {
            if (gallery.Count>=0)
            {
                Console.WriteLine("Ban phai xoa bot anh.");
                DeleteImage();
            }
            else
            {
                gallery.Add(img);
                Console.WriteLine("Them thanh cong");
            }
        }

        public void DeleteImage()
        {
            Console.WriteLine("Danh sach cac anh:");
            foreach (var VARIABLE in gallery)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.Write("Ban muon xoa anh so:");
            var del = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(gallery[del]);
            gallery.RemoveAt(del);
        }
    }
}