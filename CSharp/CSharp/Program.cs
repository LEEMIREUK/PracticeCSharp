using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        // 객체지향 -> 은닉성
        class Knight
        {
            public int Hp { get; set; } = 100;
        }
        
        static void Main(string[] args)
        {
            Knight knight = new Knight();

            int hp = knight.Hp;
        }
    }
}
