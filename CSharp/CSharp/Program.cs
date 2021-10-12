using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // break -------------------------------
            
            int num = 10000002;
            bool isPrime = true;
            for(int i = 2; i< num; ++i)
            {
                if(num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if(isPrime)
                Console.WriteLine("소수입니다.");
            else
                Console.WriteLine("소수가 아닙니다.");
        
            //continue -----------------------------

            for(int i = 1; i<= 100; ++i)
            {
                // continue를 활용해서 코드를 작성할 때 여러 조건들을 처리해주는것이 좋다.
                if (i % 3 != 0)
                    continue;

                Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}");
            }
        }
    }
}
