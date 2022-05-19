using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = Convert.ToInt32(Console.ReadLine());
            int[] ArrayNum = new int[N];
            var rand = new Random();

            for (int i = 0; i < ArrayNum.Count(); i++)
            {
                ArrayNum[i] = rand.Next(0, 100);
            }

            Console.WriteLine(ArrayNum.Max());
            Console.WriteLine(ArrayNum.Min());
            Console.WriteLine(ArrayNum.Sum());
            Console.WriteLine(ArrayNum.Sum() / (double)ArrayNum.Count());
            foreach (int num in ArrayNum)
            {
                if (num % 2 == 0)
                    Console.Write(num + " ");
            }

            Console.ReadLine();
        }
    }
}
