using System;
namespace CSClass
{
    class MyMath
    {
        public static int Abs(int v)
        {
            Console.WriteLine("int Abs");
            return (v < 0) ? -1 * v : v;
        }

        public static double Abs(double v)
        {
            Console.WriteLine("double Abs");
            return (v < 0) ? -1 * v : v;
        }

        public static long Abs(long v)
        {
            Console.WriteLine("long Abs");
            return (v < 0) ? -1 * v : v;
        }
    }
}