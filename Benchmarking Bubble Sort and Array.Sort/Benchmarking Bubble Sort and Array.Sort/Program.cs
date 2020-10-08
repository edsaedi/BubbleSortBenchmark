using System;

using BenchmarkRunner;

namespace Benchmarking_Bubble_Sort_and_Array.Sort
{
    class Program
    {
        static void BubbleSort(int[] array)
        {
            bool didSwap;

            do
            {
                didSwap = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if(array[i] > array[i + 1])
                    {
                        didSwap = true;
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }


            } while (didSwap);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Call benchmark on a function that has Bubble Sort and the VS sort and Write the function for the thing.
            BenchmarkRunner.BenchmarkRunner.Run<Program>();
        }
    }
}
