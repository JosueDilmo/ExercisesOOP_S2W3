using ExercisesOOP_S2W3.Question1;
using ExercisesOOP_S2W3.Question2;
using System;

namespace ExercisesOOP_S2W3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercises S2W3");
            Console.WriteLine("Question .1");
            Console.WriteLine("Question .2");
            Console.WriteLine("Question .3");
            Console.Write("Choose a question: ");
            int menuOpt = Convert.ToInt32(Console.ReadLine());
            switch (menuOpt)
            {
                case 1:
                    ValidPayRate valid = new();
                    valid.validPay();
                    break;
                case 2:
                    SumInteger sum = new();
                    sum.sumInteger();
                    break;
                case 3:
                    break;
            }
        }
    }
}
