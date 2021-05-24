using System;

namespace T2008M_AP.All_AP.ss4
{
    public class DemoDelegate
    {
        public delegate void publicDelegate(int a,int b);
        public static void Main(string[] args)
        {
            publicDelegate publicDelegate = new publicDelegate(Cong);
            publicDelegate += Tru;
            publicDelegate += Nhan;
            publicDelegate += Chia;
            publicDelegate(2, 4);
        }
        public static void Cong(int a,int b)
        {
         Console.WriteLine(a+b);   
        }

        public static void Tru(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        public static void Nhan(int a, int b)
        {
            Console.WriteLine(a*b);   
        }

        public static void Chia(int a, int b)
        {
            Console.WriteLine(Convert.ToSingle(a) / b);
        }
    }
    
    
}