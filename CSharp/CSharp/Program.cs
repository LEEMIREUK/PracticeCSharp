using System;

namespace CSharp
{
    class Program
    {
        class Map
        {
            int[,] tiles = {
                { 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1 }
            };
            public void Render()
            {
                ConsoleColor defaultColor = Console.ForegroundColor;
                for (int x = 0; x < tiles.GetLength(0); ++x)
                {
                    for (int y = 0; y < tiles.GetLength(1); ++y)
                    {
                        if (tiles[x, y] == 1)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('\u25cf');
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = defaultColor;
            }
        }
        static void Main(string[] args)
        {
            //int[,] map = new int[2, 3];
            // 이미 크기를 고정해놓았다.
            // 가변 배열은 어떻게 할까?
            int[][] a = new int[3][];
            // 2번째것의 크기를 지정해주지 않는 이유는 상황에 맞게 크기를 정해줄수 있다.
            a[0] = new int[2];
            a[1] = new int[6];
            a[2] = new int[3];

            // [ . . ]
            // [ . . . . . . ]
            // [ . . .]

            Map map = new Map();
            map.Render();
        }
    }
}
