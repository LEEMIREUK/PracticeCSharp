using System;

namespace CSharp
{
    // 객체 (OOP Object Oriented Programming)
    // 객체지향의 3대 속성 (은닉성/상속성/다형성)

    class Player    // 부모 / 기반 클래스
    {
        static public int counter = 1;    // 오로지 1개만 존재

        public int id;
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자 호출");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자 호출");
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
    class Mage : Player
    {

    }

    class Archer : Player
    {

    }

    class Knight : Player   // 자식 / 파생 클래스
    {
        public Knight() : base(100)
        {
            base.hp = 100;
            Console.WriteLine("Knight 생성자 호출");
        }
        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 100;
            return knight;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
        }
    }
}
