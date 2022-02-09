using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOOP_S2W3.Question1
{
    public class ValidPayRate
    {
        public void validPay()
        {
            Console.WriteLine("Valid Pay Rate App");
            Console.WriteLine("==================");
            Console.Write("Enter the hourly pay rate: ");
            decimal payRate;
            while (!decimal.TryParse(Console.ReadLine(), out payRate) || (payRate < (decimal)5.65 || payRate > (decimal)49.99))
            {
                Console.WriteLine("Invalid pay rate.");
                Console.Write("Enter your hourly pay rate: ");
            }
            Console.WriteLine("You've entered a valid rate.");
            Console.WriteLine($"Valid hourly pay rate ${payRate}");
            Console.WriteLine("=============");
        }
    }
}
