using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler7
{
    class Program   // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    {               // What is the 10 001st prime number?  
        static void Main(string[] args)
        {
            int primeCounter = 0;
            int lastPrime = 0;
            for(int i = 2; primeCounter != 10000; i++)
            {
                if(CheckIsPrime(i) == true)
                {
                    primeCounter++;
                    lastPrime = i;
                    // for debug only
                    Console.WriteLine($"{primeCounter} -> {lastPrime}");
                }
            }
            Console.Write(lastPrime);
            Console.ReadKey();
        }
        static bool CheckIsPrime(int num)
        {
            int divider = 2;
            while(num % divider != 0)
            {
                divider++;
                if (num == divider)
                {
                    return true;
                }
            } 
            return false;
        }
    }
}
