using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Practical6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] array = { 75, 14, 43, 10, 52, 11, 90 };

            Console.WriteLine("Початковий масив:");
            PrintArray(array);

            BubbleSort(array);

            Console.WriteLine("\nВідсортований масив:");
            PrintArray(array);
        }

        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
