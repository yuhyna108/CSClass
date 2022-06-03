using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        /*class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

            public static double Abs(double input)
            {
                if (input < 0) { return input; }
                else { return input; }
            }

            public static long Abs(long input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }
        }*/

        static void Main(string[] args)
        {
            Car car = new Car(); //Alt + Enter
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble()*10);

            /*List<int> list = new List<int>();
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);*/
            List<int> list = new List<int>() { 52,273,32,24};
            list.Remove(52);

            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem : " + item);
            }

            //Math 클래스
            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));
            Console.WriteLine(Math.PI);

            Hamburger nyam = new Hamburger(); // 클래스명과 파일명이 달라도된다. | 자바는 다르면 안됨

            Product productA = new Product();
            productA.name = "포켓몬빵";
            productA.price = 1500;

            //인스턴스 변수를 생성과 동시에 초기화(C# 고유 문법)
            Product productB = new Product() { name = "소금빵", price=2000};
            Product productC = new Product() { price=5500, name="당근케이크"};
            Product productD = new Product() { name="보름달" };

            /* List<Student> students = new List<Student>();
             students.Add(new Student() { name = "유현아", grade = 1 });
             students.Add(new Student() { name = "최승철", grade = 2 });
             students.Add(new Student() { name = "윤정한", grade = 2 });
             students.Add(new Student() { name = "홍지수", grade = 2 });
             students.Add(new Student() { name = "문준희", grade = 3 });
             students.Add(new Student() { name = "권순영", grade = 3 });
             students.Add(new Student() { name = "전원우", grade = 3 });
             students.Add(new Student() { name = "이지훈", grade = 4 });
             students.Add(new Student() { name = "서명호", grade = 4 });
             students.Add(new Student() { name = "김민규", grade = 4 });
             students.Add(new Student() { name = "이석민", grade = 5 });
             students.Add(new Student() { name = "부승관", grade = 5 });
             students.Add(new Student() { name = "최한솔", grade = 5 });
             students.Add(new Student() { name = "이  찬", grade = 6 });*/

            List<Student> students = new List<Student>()
            {
                new Student() { name = "유현아", grade = 1 },
                new Student() { name = "최승철", grade = 2 },
                new Student() { name = "윤정한", grade = 2 },
                new Student() { name = "홍지수", grade = 2 },
                new Student() { name = "문준희", grade = 3 },
                new Student() { name = "권순영", grade = 3 },
                new Student() { name = "전원우", grade = 3 },
                new Student() { name = "이지훈", grade = 2 },
                new Student() { name = "서명호", grade = 2 },
                new Student() { name = "김민규", grade = 2 },
                new Student() { name = "이석민", grade = 1 },
                new Student() { name = "부승관", grade = 1 },
                new Student() { name = "최한솔", grade = 2 },
                new Student() { name = "이  찬", grade = 1 },
            };

            /*foreach (var item in students)
            {
                if (item.grade > 2)
                {
                    students.Remove(item);
                }
            }*/
            for(int i=0; i<students.Count; i++)
            {
                if(students[i].grade > 2)
                {
                    students.RemoveAt(i);
                    //students.Remove(students[i]);
                    i--;
                }
            }
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            Method method = new Method();
            Console.WriteLine(method.Multi(52.1, 273));
            Console.WriteLine(method.Sum(1,100));
            Console.WriteLine(method.Multiply(1,10));

            //int
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));

            //doouble
            Console.WriteLine(MyMath.Abs(52.273));
            Console.WriteLine(MyMath.Abs(-32.103));

            //long
            Console.WriteLine(MyMath.Abs(21474836470));
            Console.WriteLine(MyMath.Abs(-21474836470));

            Sample sample = new Sample();

            Box1 box1 = new Box1(10, 10);
            box1.width = -10;
            Console.WriteLine("box1의 면적은 : " + box1.Area());

            Box2 box2 = new Box2(10, 10);
            box2.setWidth(-10);
            Console.WriteLine("box2의 면적은 : " + box2.Area());

            Box box = new Box(10, 10);
            box.Width = -10;
            Console.WriteLine("box의 면적은 : " + box.Area);

            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(10));
            //Console.WriteLine(Fibonacci.Get(100));
            //Console.WriteLine(Fibonacci.Get(1000));

        }

    }

}
