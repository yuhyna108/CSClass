using System;
using System.Collections.Generic;

namespace CSClass
{
    class Fibonacci
    {
        private static Dictionary<int, long> memo = new Dictionary<int, long>();

        public Fibonacci()
        {

        }
        public static long Get(int i)
        {
            Console.Write("Get(" + i + ") 호출 -> ");
            if (i < 0) { return 0; }
            if (i == 1) { return 1; }

            Console.WriteLine();
            if (memo.ContainsKey(i)) { return memo[i]; }
            else
            {
                memo[i] = Get(i - 2) + Get(i - 1);
                return memo[i];
            }

            return Get(i - 2) + Get(i - 1);
        }
    }
}