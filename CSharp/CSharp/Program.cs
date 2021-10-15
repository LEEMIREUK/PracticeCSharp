using System;

namespace CSharp
{
    // 객체 (OOP Object Oriented Programming)
    // 객체지향의 3대 속성 (은닉성/상속성/다형성)

    class Player
    {
        protected int hp;
        protected int attack;
    }
    class Knight : Player
    {

    }
    class Mage : Player
    {
        public int mp;
    }

    class Program
    {
        static void EnterGame(Player player)
        {
            Mage mage = (player as Mage);
            if(mage != null)
            {
                mage.mp = 10;
            }
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            // Mage 타입 -> Player 타입 변환가능
            // Player 타입 -> Mage 타입 변환 바로 불가능, 명시를 해줘야함
            Player magePlayer = mage;
            Mage mage2 = (Mage)magePlayer;

            EnterGame(knight);
        }
    }
}
