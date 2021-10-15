using System;

namespace CSharp
{
    // 객체 (OOP Object Oriented Programming)
    // 객체지향의 3대 속성 (은닉성/상속성/다형성)

    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }
    }
    class Knight : Player
    {
        public override void Move()
        {
            Console.WriteLine("Knight 이동!");
        }
    }
    class Mage : Player
    {
        public int mp;

        public override void Move()
        {
            Console.WriteLine("Mage 이동!");
        }
    }

    class Program
    {
        static void EnterGame(Player player)
        {
            player.Move();
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            EnterGame();
        }
    }
}
