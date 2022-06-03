using System;

namespace CSClass
{
    public class Sample
    {
        public static int value = 42;

        public Sample()
        {
            value = 99;
            Console.WriteLine("Sample() 생성자 호출");
        }
        ~Sample() // 소멸자
        {
            Console.WriteLine("샘플 객체의 소멸자가 호출되었습니다!!");
        }
    }
}