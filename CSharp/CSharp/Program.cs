using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 거울아 거울아~
            string answer;

            do
            {
                Console.WriteLine("나는 잘생겼나요? (y / n) : ");
                answer = Console.ReadLine();
            } while (answer != "y");

            Console.WriteLine("정답입니다.");
        }
    }
}
