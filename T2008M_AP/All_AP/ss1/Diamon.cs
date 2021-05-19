using System;

namespace T2008M_AP.All_AP.ss1
{
    public class Diamon:Product
    {
        public int cara;
        public override bool CheckQty(int qty)
        {
            var rs= base.CheckQty(qty);
            Console.WriteLine(rs?"Hang that":"Hang gia");
            return rs;
        }
    }
}