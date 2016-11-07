using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Painting_Estimate
{
    class Painting
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter the width of your room");
            int width=Convert.ToInt32(ReadLine());
            WriteLine("Please enter the length of your room");
            int length = Convert.ToInt32(ReadLine()); ;
            
            WriteLine("The Estimate for painting this room is $"+ Estimator(width, length));
        }

        public static int Estimator(int w,int l)
        {
            int costPerSqFt = 6;
            int height = 9;
            int wallFootage = ((l * height) * 2) + ((w * height) * 2);

            int estimate = wallFootage * costPerSqFt;
            return estimate;

        }
    }
}
