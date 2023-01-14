using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Csharp basic programs");
            Console.WriteLine("Please Enter first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter second number");
            int second = Convert.ToInt32(Console.ReadLine());

            Calculator calculator = new Calculator(first, second);
            calculator.Addition();
            Console.ReadLine();
        }
    }
}
