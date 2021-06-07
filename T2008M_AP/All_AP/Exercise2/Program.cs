using System;

namespace T2008M_AP.All_AP.Exercise2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Lion lion = new Lion();
            lion.SetMe(200,"lion");
            lion.Show();
            Tiger tiger = new Tiger();
            tiger.SetMe(100,"tiger");
            tiger.Show();
        }
    }
}