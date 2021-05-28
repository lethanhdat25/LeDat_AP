using System;
using System.Threading;
using Microsoft.SqlServer.Server;

namespace T2008M_AP.All_AP.ss5
{
    public class DemoThread
    {
        public static void Main(string[] args)
        {
            Thread t = new Thread(demnguoc);
            t.Start();
        }

        public static void demnguoc()
        {
            int phut = 10;
            int giay = 0;
            do
            {
                
                Console.WriteLine(phut+ " : "+giay);
                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                giay--;
                while (giay<0)
                {
                    giay = 59;
                    phut--;
                    
                }
            } while (phut>=0);
            Console.WriteLine("Bum...");
        }
    }
}