using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter in the first number?");

            //int intergerOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter in the second number");

            //int intergerTwo = int.Parse(Console.ReadLine());

            //if (intergerOne == intergerTwo)
            //{
            //    Console.WriteLine("Your numbers are the same");
            //}
            //else
            //{
            //    Console.WriteLine("Your numbers are not the same");
            //}

            //tell user if number is even or odd

            //Console.WriteLine("please enter in a whole number");
            //int numberOne = int.Parse(Console.ReadLine());

            //if (numberOne % 2 == 0)
            //{
            //    Console.WriteLine("Your number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is odd");
            //}

            //tell user if number is positive or negative

            //Mini FizzBuzz Problem
            //fizz number
            Console.WriteLine("Please Insert Your Fizz Number (1-9)");
            int fizzNum = int.Parse(Console.ReadLine());
            
            //buzz number
            Console.WriteLine("Please Insert Your Buzz Number (1-9)");
            int buzzNum = int.Parse(Console.ReadLine());

            //test number
            Console.WriteLine("Please Insert Your Test Number");
            int testNum = int.Parse(Console.ReadLine());

            //testing fizz,buzz,fizzbuzz, error
            if (testNum % fizzNum == 0 && testNum % buzzNum == 0)
            {
                Console.WriteLine("Congrats you have a FizzBuzz");
                
            }
            else if (testNum % fizzNum == 0 && testNum % buzzNum != 0)
            {
                Console.WriteLine("Congrats you have a Fizz");
                
            }
            else if(testNum % buzzNum ==0 && testNum % fizzNum !=0)
            {
                Console.WriteLine("Congrats you have a Buzz");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
