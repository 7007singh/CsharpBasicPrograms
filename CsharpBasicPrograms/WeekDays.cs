using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicPrograms
{
    internal class WeekDays
    {
        public static void FindADayWhichFallOnWeek(int dayNumber)
        {
            switch(dayNumber)
            {
                case 1:
                    Console.WriteLine("Its a Monday");
                    break;
                case 2: 
                        Console.WriteLine("Its a Tuesday");
                    break;
                case 3: 
                        Console.WriteLine("Its a Wednesday");
                    break;
                case 4: 
                        Console.WriteLine("Its a Thrusday");
                    break;
                case 5: 
                        Console.WriteLine("Its a Friday");
                    break;
                case 6:
                        Console.WriteLine("Its a Saturday");
                    break;
                case 7: 
                        Console.WriteLine("Its a Sunday");
                    break;
                default: 
                        Console.WriteLine("Please enter a number between 1 to 7");
                    break;
            }
        }
    }
}
