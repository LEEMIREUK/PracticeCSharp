using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[1000];
            // 메모리 낭비일 수 있다.

            // List <- 동적 배열
            List<int> list = new List<int>();
         
            // 삽입 삭제
            for (int i = 0; i < 5; ++i)
                list.Add(i);

            list.Remove(999);
            list.RemoveAt(0);

            for (int i = 0; i < 5; ++i)
                Console.WriteLine(list[i]);
            foreach (int num in list)
                Console.WriteLine(num);

        }
    }
}
