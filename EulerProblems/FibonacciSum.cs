using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class FibonacciSum
    {
        public static int SumTheEvenFibs(string numToSum)
        {
            int number = Convert.ToInt32(numToSum);
            int sum = 0;
            int tempSum = 0;
            
            for (int i = 1; tempSum < number; i++)
            {
                tempSum = ShowNthFibonacciNum(i);

                if (tempSum % 2 == 0)
                    sum += tempSum;
            }
            return sum;
        }
        
        public static int ShowNthFibonacciNum(int n)
        {
            int result = 0;
            
            if (n == 1)
                result = 1;

            else if (n == 2)
                result = 2;

            else
            {
                result = ShowNthFibonacciNum(n - 2) + ShowNthFibonacciNum(n - 1);
            }
            return result;
        }
    }
}