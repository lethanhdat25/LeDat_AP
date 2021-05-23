using System.Collections.Generic;

namespace T2008M_AP.All_AP.ss2
{
    public class Product
    {
        public string producName;
        public decimal price;

        public string ProducName
        {
            get => producName;
            set => producName = value;
        }

        public decimal Price
        {
            get => price;
            set => price = value;
        }

        public List<string> gallery = new List<string>(); 
        // ban than List cung da co indexers
        // indexers
        public string this[int index]
        {
            get { return gallery[index]; }
            set { gallery[index] = value; }
        }
    }

    
}