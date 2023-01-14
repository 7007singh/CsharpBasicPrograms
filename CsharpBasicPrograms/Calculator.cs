using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
        public int first, second, sum;

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
            sum = first + second;
            Console.WriteLine("sum:" + sum);
        }

        public void Substraction()
        {
            sum = Math.Abs(first - second);
            Console.WriteLine("diff:" + sum);
        }
    }
}
