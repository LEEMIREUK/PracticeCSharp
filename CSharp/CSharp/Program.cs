using System;

namespace CSharp
{
    class Program
    {
        // 함수 이름의 재사용 - 오버로딩
        static int Add(int a, int b)
        {
            return a + b;
        }
        // static void Add(int a, int b)는 불가능하다.
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        static int Add2(int a, int b, int c = 0)
        {
            return a + b + c;
        }
        static float Add(float a, float b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int ret = Program.Add(2, 3);
            int ret2 = Program.Add(2, 3, 5);
            float ret3 = Program.Add(2.0f, 3.0f);

            int ret4 = Program.Add2(2, 3);
            int ret5 = Program.Add2(2, 3, c:5);
        }
    }
}
