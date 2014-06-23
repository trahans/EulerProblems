using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class PalindromeProducts
    {
        static List<int> palindromes = new List<int>();
        
        public static int FindLargestPalindrome()
        {
            for (int i = 999; i >= 100; i--)
            {
                for (int j = 999; j >= 100; j--)
                {
                    int workingValue = i * j;

                    if (CheckIfNumIsPal(workingValue))
                        palindromes.Add(workingValue);
                }
            }
            return ReturnLargestValueInList();
        }

        public static int ReturnLargestValueInList()
        {
            int largestPal = 0;

            foreach (int pal in palindromes)
            {
                if (pal > largestPal)
                    largestPal = pal;
            }

            return largestPal;
        }

        public static bool CheckIfNumIsPal(int num)
        {
            string numAsString = ConvertNumToString(num);
            string reverseOfInput = ReverseOfInput(numAsString);

            if (reverseOfInput == numAsString)
                return true;

            else
                return false;
        }

        public static string ConvertNumToString(int num)
        {
            string numAsString = num.ToString();

            return numAsString;
        }

        public static string ReverseOfInput(string inputNum)
        {
            char[] inputAsArray = inputNum.ToCharArray();
            Array.Reverse(inputAsArray);
            string reverseOfInput = new string(inputAsArray);

            return reverseOfInput;
        }
    }
}
