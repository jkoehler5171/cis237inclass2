using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237InClass2
{
    class Factorial
    {
        public Factorial()
        {
            Console.WriteLine("Input a number to calculate the factorial of:");

            try
            {
                int factorialInt = Convert.ToInt32(Console.ReadLine());
                
                if(factorialInt < 31)
                {
                    Console.WriteLine(Environment.NewLine + "Problem: " + factorialInt + "!");
                    //This call will calucalte factorial by using the recursive method
                    int answerInt = Calculate(factorialInt);

                    Console.WriteLine(Environment.NewLine + "The answer is: " + answerInt);
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine(Environment.NewLine + "You must enter a number < 30");
                }

            }
            catch
            {
                Console.WriteLine(Environment.NewLine + "You must enter a number");
            }
        }
        /// <summary>
        /// Calculates the factorial of the number that is passed in.
        /// </summary>
        /// <param name="number">Integer</param>
        /// <returns>The Answer</returns>


        public int Calculate(int number)
        {
            if (number==1)
            {
                return number;
            }
            else
            {
                return number * Calculate(number - 1);
            }
        }
    }
}
