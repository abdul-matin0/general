using System;

namespace General
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[5];

            Numbers[0] = 5;
            Numbers[1] = 9;
            Numbers[2] = 15;
            Numbers[3] = 19;

            // ArrayList, HashTable and Generics
            foreach(int i in Numbers)
            {
                if (i == 9)
                    continue;

                Console.WriteLine(i);
            }

            //int i = 0;

            //while(i < Numbers.Length)
            //{
            //    Console.WriteLine(Numbers[i]);
            //    i++;
            //}
        }
    }
}
