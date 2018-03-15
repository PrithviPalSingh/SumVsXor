using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumVsXor
{
    class Program
    {
        //Need to use 1L to change int to long.
        static long solve(ulong n)
        {
            int unset_bits = 0;
            while (n > 0)
            {
                if ((n & 1) == 0)
                    unset_bits++;
                n = n >> 1;
            }         

            // Return 2 ^ unset_bits
            return 1L << unset_bits;
        }

        /// <summary>
        /// a+b = a^b + 2(a&b)
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            ulong n = Convert.ToUInt64(Console.ReadLine());
            long result = solve(n);
            Console.WriteLine(result);
            Console.Read();
        }

        static long XOR(long n, long x)
        {
            return n ^ x;
        }

        static long SUM(long n, long x)
        {
            return n + x;
        }
    }
}
