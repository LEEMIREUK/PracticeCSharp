using System;

namespace CSharp
{
    class Program
    {
        enum Choice
        {
            Rock = 1,
            Paper = 2,
            Scissors = 0
        }


        // 주석을 달 수 있다.
        static void Main(string[] args)
        {
            // 0: 가위 1: 바위 2: 보

            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); // 0 ~ 2 사이의 랜덤 값
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("당신은 가위입니다.");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("당신은 바위입니다.");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("당신은 보입니다.");
                    break;
            }

            switch (aiChoice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("컴퓨터의 가위입니다.");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("컴퓨터의 바위입니다.");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("컴퓨터의 보입니다.");
                    break;
            }

            // 승리 무승부 패배
            //if (choice == 0)
            //{
            //    if (aiChoice == 0)
            //    {
            //        Console.WriteLine("무승부입니다.");
            //    }
            //    else if(aiChoice == 1)
            //    {
            //        Console.WriteLine("패배입니다..");
            //    }
            //    else
            //    {
            //        Console.WriteLine("승리입니다..");
            //    }
            //}
            //else if (choice == 1)
            //{
            //    if (aiChoice == 0)
            //    {
            //        Console.WriteLine("승리입니다.");
            //    }
            //    else if (aiChoice == 1)
            //    {
            //        Console.WriteLine("무승부입니다.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("패배입니다.");
            //    }
            //}
            //else
            //{
            //    if (aiChoice == 0)
            //    {
            //        Console.WriteLine("패배입니다.");
            //    }
            //    else if (aiChoice == 1)
            //    {
            //        Console.WriteLine("승리입니다.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("무승부입니다.");
            //    }
            //}

            if(choice == aiChoice)
            {
                Console.WriteLine("무승부입니다.");
            }
            else if (choice == (int)Choice.Scissors &&  aiChoice == (int)Choice.Paper)
            {
                Console.WriteLine("승리입니다.");
            }
            else if (choice == (int)Choice.Rock && aiChoice == (int)Choice.Scissors)
            {
                Console.WriteLine("승리입니다.");
            }
            else if (choice == (int)Choice.Paper && aiChoice == (int)Choice.Rock)
            {
                Console.WriteLine("승리입니다.");
            }
            else
            {
                Console.WriteLine("패배입니다.");
            }
        }
    }
}
