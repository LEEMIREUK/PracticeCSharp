using System;

namespace CSharp
{
    class Program
    {
        // 주석을 달 수 있다.
        static void Main(string[] args)
        {
            // 데이터 + 로직

            // byte(1바이트 0 ~ 255), short(2바이트 -3만 ~ 3만), int(4바이트 -21억 ~ 21억), long(8바이트)
            // sbyte(1바이트 -128 ~ 127), ushort(2바이트 0 ~ 6만), uint(4바이트 0 ~ 43억), ulong(8바이트)

            // 변수
            int hp;
            hp = 100;

            // 언더플로우 예시
            byte num;
            num = 0;
            Console.WriteLine("{0}", num);
            num -= 1;
            Console.WriteLine("{0}", num);
        }
    }
}
