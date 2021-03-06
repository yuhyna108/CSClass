using System;

namespace CSClass
{
    class Method
    {
        public double Multi(double v1, double v2)
        {
            return v1 * v2;
        }

        /// <summary>
        /// min부터 max까지의 합
        /// </summary>
        /// <param name="min">시작값</param>
        /// <param name="max">최댓값</param>
        /// <returns>min부터 max가지의 합계</returns>
        public int Sum(int min, int max)
        {
            int output = 0;
            for(int i = min; i < max; i++)
            {
                output += i;
            }
            return output;
        }

        /// <summary>
        /// min부터 max까지의 곱
        /// </summary>
        /// <param name="min">시작값</param>
        /// <param name="max">최댓값</param>
        /// <returns>min부터 max가지의 곱</returns>
        public int Multiply(int min, int max)
        {
            int output = 1;
            for (int i = min; i < max; i++)
            {
                output *= i;
            }
            return output;
            some(); // static메소드 접근가능
        }

        static public void some()
        {
            //this.Multiply(1, 10); 일반메소드 접근 불가능

        }
    }
}