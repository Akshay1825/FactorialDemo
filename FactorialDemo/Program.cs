using FactorialDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();

            Console.WriteLine("Enter a number :");
            int number = int.Parse(Console.ReadLine());

            int fact = factorial.CalculateFactorial(number);

            Console.WriteLine($"The factorial of {number} is {fact}.");
        }
    }
}
