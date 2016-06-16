using System;
using RaviUtils;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Solution
{
    static void Main(string[] args)
    {
        int n = 337;
        Console.WriteLine(Basics.isPrime(n));
    }
}


namespace RaviUtils
{
    static class Basics
    {
        /* Usage: Checks if a number n is prime
           Description: Check if n is divisible by any non even number upto Sqrt of n */

        public static bool isPrime(int n)
        {
            bool flag = false;
            if (n == 2)
                return true;
            for (int i = 3; i < Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                {
                    flag = false;
                    break;
                }
                flag = true;
            }

            return flag;
        }
    }

}