using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 9;
            int second = 0;
            Console.WriteLine("Enter your first number: ");
            first = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            second = System.Int32.Parse(Console.ReadLine());
            int result = Divide(first, second);
            Console.WriteLine($"The result of dividing {first} by {second} is {result}");

            Console.ReadLine();
        }

        static int Divide(int first , int second)
        {
            int result = 0;
            try
            {
                result = first / second;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zeo value for your secound value");
            }
            return result;
        }
    }
}
