using System;

namespace CSharp
{
    class Program
    {
        static int GetHightestScore(int[] scores)
        {
            int max = 0;
            foreach(int score in scores)
            {
                if (max < score)
                    max = score;
            }
            return max;
        }

        static int GetAverageScore(int[] scores)
        {
            if (scores.Length == 0)
                return 0;

            int sum = 0;
            foreach (int score in scores)
                sum += score;

            return sum / scores.Length;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            for(int i = 0; i< scores.Length; ++i)
            {
                if (scores[i] == value)
                    return i;
            }
            return -1;
        }

        static void Sort(int[] scores)
        {
            for( int i = 0; i< scores.Length; ++i)
            {
                // 제일 작은 숫자가 있는 index찾기
                int minIndex = i;
                for (int j = i; j < scores.Length; ++j)
                {
                    if (scores[j] < scores[minIndex])
                        minIndex = j;
                }

                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
            //for (int i = 0; i < scores.Length; ++i)
            //{
            //    for (int j = 0; j < scores.Length - 1; ++j)
            //    {
            //        if (scores[j] > scores[j + 1])
            //        {
            //            int temp = scores[j + 1];
            //            scores[j] = scores[j + 1];
            //            scores[j] = temp;
            //        }
            //    }
            //}
        }

        static void Main(string[] args)
        {
            // 배열
            int[] scores = new int[] { 10, 30, 40, 20, 50 };
            int highestScore = GetHightestScore(scores);
            Console.WriteLine(highestScore);

            int averageScore = GetAverageScore(scores);
            Console.WriteLine(averageScore);

            int index = GetIndexOf(scores, 20);
            Console.WriteLine(index);

            Sort(scores);
        }
    }
}
