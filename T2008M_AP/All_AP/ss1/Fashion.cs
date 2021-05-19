
using System;

namespace T2008M_AP.All_AP.ss1
{
    public class Fashion:Product
    {
        public string mausac;
        public string kichco;
        public override bool CheckQty(int qty)
        {
            var rs= base.CheckQty(qty);
            if (rs)
            {
                Console.WriteLine("Tronog kho con mau :"+this.mausac+" va size :"+this.kichco);
                return rs;
            }

            return rs;
        }
    }
}