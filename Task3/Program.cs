using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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
            ArrayNum = MyReverse(ArrayNum); ShowArray(ArrayNum);
            ArrayNum = SubArray(ArrayNum, 2, 5); ShowArray(ArrayNum);

            Console.ReadLine();
        }
        static int[] MyReverse(int[] array)

        {
            int[] revertArray = new int[array.Count()];
            int i = array.Count() - 1;
            foreach (int item in array)
            {
                revertArray[i] = item;
                i--;
            }

            return revertArray;
        }
        static int[] SubArray(int[] array, int index, int count)
        {
            int[] newArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                int j = i + index;
                if (j < array.Count())
                {
                    newArray[i] = array[j];
                }
                else newArray[i] = 1;
            }

            return newArray;
        }
        static void ShowArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
