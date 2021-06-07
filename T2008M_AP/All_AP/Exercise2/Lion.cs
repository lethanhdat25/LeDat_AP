using System;

namespace T2008M_AP.All_AP.Exercise2
{
    public class Lion : Animal
    {

        public override void Show()
        {
            Console.WriteLine("Name: "+base.Name+", Weight: "+base.Weight);
        }

        public override void SetMe(int weight, string name)
        {
            
            base.Weight = weight;
            base.Name = name;
        }
    }
}