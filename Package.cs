using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDemo
{
    class Package
    {
        public int IDNum { get; set; }
        public string Name { get; set; }
        public int Ounces { get; set; }
        public double Price { get; set; }

        public Package(int idNum, string name, int ounces)
        {
            this.IDNum = idNum;
            this.Name = name;
            this.Ounces = ounces;
            

            if (ounces < 32)
            { Price = 5; }
            else if(ounces>32)
            {
                int leftover = ounces - 32;
                Price = (leftover * .12) + 5;     
           }
        }
        public override string ToString()
        {
            return "Package Number:" + IDNum + "\nTo " + Name + "\nTotal Weight: "+ Ounces +"\nCost to ship:"+Price;
        }

    }
}
