using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicPrograms
{
    /// <summary>
    /// Calculator class created to perform arithmetics operations
    /// </summary>
    class Calculator
    {
        //instance variables
        public int first, second, result;

        public Calculator(int firstNum,int secondNum) 
        {
            first= firstNum;
            second= secondNum;
        }

        /// <summary>
        /// Addition of two numbers
        /// </summary>
        public void Addition()
        {
            result = first + second;
            Console.WriteLine("sum:"+result);
        }
    }
}
