using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOOP_S2W3.Question2
{
    public class SumInteger
    {
        public void sumInteger()
        {
            //basic loop to add integers and when the loop is done display the number that is in sum.
            int sum = 0;
            for (int i = 0; i <= 50; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of integers from 1 to 50 is: {sum}");

            // with this library had to put up to 51 because the last number to enter in the calculation was 49.
            var answer = Enumerable.Range(0, 51);
            Console.WriteLine("The sum from 1 to 50 is:" + answer.Sum());
        }
    }
}
