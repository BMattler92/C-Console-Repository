using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SubscriptExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] values = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            try
            {
              for(int x=0;x<5;x++)
                {
                   WriteLine("Please enter which position you would like to see?");
                   int i = Convert.ToInt32(ReadLine());
                   WriteLine("The value in position" + i + " is " + values.GetValue(i)+".");
                } 
            }
            catch(IndexOutOfRangeException ex)
            {
                WriteLine(ex.Message);
            } 
        }
    }
}
