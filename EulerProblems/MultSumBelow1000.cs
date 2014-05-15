﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class MultSumBelow1000
    {
        public static int Answer
        {
            get
            {
                return SumOfMult3And5();
            }
        }
        
        static int SumOfMult3And5()
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
