using System;

namespace T2008M_AP.All_AP.GeometryExample
{
    public class Cylinder
    {
        
        public double BaseArea, LateralArea, TotalArea, Volume;

        public void Process(double radius, double height)
        {
            BaseArea = Math.Pow(radius, 2) * Math.PI;
            LateralArea = 2 * Math.PI * radius * height;
            TotalArea = 2 * Math.PI * radius * (height + radius);
            Volume = Math.PI * Math.Pow(radius, 2) * height;
        }

        public void Result(double radius, double height)
        {
            Console.Write("Radius: " + radius);
            Console.WriteLine(", Height: " + height);
            Process(radius, height);
            Console.Write("Base: " + BaseArea + " | ");
            Console.Write("Lateral: " + LateralArea + " | ");
            Console.Write("Total: " + TotalArea + " | ");
            Console.Write("Volume: " + Volume);
        }
        
        public static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder();
            Console.WriteLine("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            cylinder.Result(radius,height);
        }
    }
}