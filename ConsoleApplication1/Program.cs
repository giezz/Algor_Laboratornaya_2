using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int x = random.Next(-100, 100);
            int y = random.Next(-100, 100);
            int z = random.Next(-100, 100);

            int[] arr = new int[] { x, y, z };

            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Минимальеный элемент массива arr: " + arr[0]);
            Console.ReadKey();
        }
    }
}
