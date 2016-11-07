using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDemo
{
    class InsuredPackage:Package
    {
        public double PackageValue { get; set; }

        public InsuredPackage(int idNum, string name, int ounces,int value) : base(idNum, name, ounces)
        {
            PackageValue = value;

        if (value<20)
            { Price = base.Price + 1; }
        else if (value>20)
            { Price = base.Price + 2.50; }
        }
    }
}
