using System;

namespace T2008M_AP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Console.WriteLine("Nhap mot so");
            int n = Convert.ToInt32(Console.ReadLine());
            int x1=0, x2=1, x3=0;
            while (x3 < n)
            {
                
                x3 = x2 + x1;
                x1 = x2;
                x2 = x3;
            }

            Console.WriteLine(x1);
        }

        
    }
}