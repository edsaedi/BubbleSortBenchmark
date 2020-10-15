using System;
using System.ComponentModel.DataAnnotations;

using BenchmarkRunner;

namespace Benchmarking_Bubble_Sort_and_Array.Sort
{
    class Program
    {
        static Random rand = new Random(26);

        static int length = 100_000;

        static int[] array = CreateArray();
        static int[] array2 = CreateArray();

        public static int[] CreateArray()
        {
            var array = new int[length];
            
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(0, length);
            }

            return array;
        }

        [Benchmark]
        public static void BubbleSort()
        {

            bool didSwap;

            do
            {
                didSwap = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        didSwap = true;
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }


            } while (didSwap);
        }


        [Benchmark]
        public static void StandardLibraryArraySort()
        {
            Array.Sort(array2);
        }



        static void Main(string[] args)
        {
            //Call benchmark on a function that has Bubble Sort and the VS sort and Write the function for the thing.
            BenchmarkRunner.BenchmarkRunner.Run<Program>();

            ;
        }
    }
}
