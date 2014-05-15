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
            MultSumBelow1000 calculator = new MultSumBelow1000();

            Console.WriteLine(calculator.answer.ToString());
            Console.ReadLine();
        }
    }
}
