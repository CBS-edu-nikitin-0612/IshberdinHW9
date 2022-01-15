using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
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
                ArrayNum[i] = rand.Next();
            }

            ShowArray(ArrayNum);
            ArrayNum = AddElement(ArrayNum, rand.Next()); ShowArray(ArrayNum);

            Console.ReadLine();
        }
        static int[] AddElement(int [] array, int value)
        {
            int[] newArray = new int[array.Count() + 1];

            for (int i = 0; i < array.Count(); i++)
            {
                newArray[i+1] = array[i];
            }
            newArray[0] = value;
            return newArray;
        }
        static void ShowArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}
