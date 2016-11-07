using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Payroll
    {
        static void Main(string[] args)
        {
            string inputpayrate;
            string inputhoursworked;

            string name;
            string ssn;
            double payrate;
            double hoursworked;

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your Social Security Number: ");
            ssn = Console.ReadLine();
           
            Console.WriteLine("Enter your hourly payrate: ");
            inputpayrate = Console.ReadLine();
            payrate = Convert.ToDouble(inputpayrate);

            Console.WriteLine("Enter the number of hours worked: ");
            inputhoursworked = Console.ReadLine();
            hoursworked = Convert.ToDouble(inputhoursworked);

            double grosspay = payrate * hoursworked;
            double federaltax = grosspay * .15;
            double statetax = grosspay * .05;
            double netpay = grosspay - federaltax - statetax;

            Console.WriteLine("Name :" + name);
            Console.WriteLine("Social Security Number: " + ssn);
            Console.WriteLine("Hours worked:" + hoursworked + "at a rate of" + payrate + "per hour.");

            Console.WriteLine("Gross pay: {0}", grosspay.ToString("C"));
            Console.WriteLine("Federal withholding:{0}",federaltax.ToString("C"));
            Console.WriteLine("State withholding:{0}", statetax.ToString("C"));
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Net pay: {0}", netpay.ToString("C"));





        }
    }
}
