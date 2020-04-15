using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    static class Extensions
    {
        private static readonly Random rnd = new Random();

        public static T getRandom<T>(this List<T> list)
        {
            return list[rnd.Next(list.Count)];
        }

        public static void Shuffle<T>(this List<T> list)
        {
            int n = list.Count;

            while (n>1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value; 
            }
        }

    }
}