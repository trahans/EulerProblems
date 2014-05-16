using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class LargestPrimeFactory
    {
        public static long FindLargestPrimeFactor(string numToFactor)
        {
            long num = Convert.ToInt64(numToFactor);             
            long largestPrimeFactor = 0;

            for (long i = (long)Math.Sqrt(num); i >= 2; i--)
            {
                if (num % i == 0 && CheckIfNumIsPrime(i) == true)
                {
                    largestPrimeFactor = i;
                    return largestPrimeFactor;
                }
            }

            return largestPrimeFactor;
        }

        public static bool CheckIfNumIsPrime(long num)
        {
            if (num == 1)
                return false;
            else if (num == 2)
                return true;
            else 
                for (long i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                        return false;
                }
            return true;
        }
    }
}
