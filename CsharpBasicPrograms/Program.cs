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

            Calculator calculator1 = new Calculator(first, second);
            calculator1.Addition();
            calculator1.Substraction();

            Console.WriteLine("Please Enter first number");
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter second number");
            int fourth = Convert.ToInt32(Console.ReadLine());
            Calculator calculator2= new Calculator(third, fourth);
            calculator2.Addition();
            Console.ReadLine();
        }
    }
}
