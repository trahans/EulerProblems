using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            for (; ; )
            {
                line = Console.ReadLine();
                Console.WriteLine(LargestPrimeFactory.FindLargestPrimeFactor(line).ToString());
            }
        }
    }
}
