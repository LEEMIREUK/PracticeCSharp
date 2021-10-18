using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharp
{
    class Program
    {
        static int Find()
        {
            return 0;
        }

        class Monster
        {
            public int Id { get; set; }
        }

        static void Main(string[] args)
        {
            //// Nullable -> Null + able
            //int? number = null;

            //int b = number ?? 0;
            //int c = (number != null) ? number.Value : 0;

            //int a = number.Value;

            //if(number != null)
            //{

            //}
            //if(number.HasValue)
            //{

            //}

            Monster monster = null;

            if(monster != null)
            {
                int monsterId = monster.Id;
            }

            int? id = monster?.Id;

            if (monster == null)
                id = null;
            else
                id = monster.Id;
         
        }
    }
}
