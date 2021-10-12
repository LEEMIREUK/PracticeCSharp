using System;

namespace CSharp
{
    class Program
    {
        //static 반환형식 이름(매개변수목록)
        //{
        //}
        static void HellowWorld()
        {
            Console.WriteLine("Hello World");
        }

        // 덧셈 함수
        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static void AddOne(ref int number)
        {
            // 주소값을 넘겨 값 변경이 가능하다.
            number += 1;
        }

        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;
            int num = 0;
            HellowWorld();
            int result = Add(a, b);
            // 참조(ref)   복사(ref없는것)
            Program.AddOne(ref num);
        }
    }
}
