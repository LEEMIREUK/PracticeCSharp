using System;

namespace CSharp
{
    // 객체 (OOP Object Oriented Programming)
    
    // 속성: hp, attack
    // 기능: Move, Attack, Die

    // Ref, 참조
    class Knight
    {
        static public int counter = 1;    // 오로지 1개만 존재

        public int id;
        public int hp;
        public int attack;

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 100;
            return knight;
        }
        public Knight()
        {
            id = counter;
            counter++;

            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }
        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }
        public void Move()
        {
            Console.WriteLine("Knight Move");
        }
        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = Knight.CreateKnight(); // static
            knight.Move(); // 일반
        }
    }
}
