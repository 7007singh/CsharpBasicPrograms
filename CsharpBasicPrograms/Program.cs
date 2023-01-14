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

            Console.WriteLine("Please choose any one program from below option");
            Console.WriteLine(  "1:Calculator\n2:SwitchCase\n10:Exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
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

                    Calculator calculator2 = new Calculator(third, fourth);
                    calculator2.Addition();
                    break;
                 case 2:
                    Console.WriteLine("Please choose a number 'from 1 to 7'");
                    int day = Convert.ToInt32(Console.ReadLine());
                    WeekDays.FindADayWhichFallOnWeek(day);
                    break;
                 case 10:
                    Console.WriteLine("Exit");
                    break;
            }
        }
    }
}
