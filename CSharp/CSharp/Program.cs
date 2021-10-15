using System;
using System.Collections.Generic;

namespace CSharp
{
    class Monster
    {
        public int id;
        public Monster(int id) { this.id = id; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            for(int i = 0;i < 10000; ++i)
            {
                dic.Add(i, new Monster(i));
            }

            Monster mon;
            bool found = dic.TryGetValue(20000, out mon);
            bool found2 = dic.TryGetValue(7777, out mon);
        }
    }
}
