using System;
using System.Collections.Generic;

namespace TrainingApp
{
    class Program
    {
        private static int i = 0;

        static void Main(string[] args)
        {
            //Console.WriteLine("Numbers divide by 5: "+string.Join(", ", GetValDiv(5,1,100)));
            //Console.WriteLine("Numbers divide by 10: "+string.Join(", ", GetValDivV2(10, 1, 100)));
            int[] ToSort = { 10, 30, 19, 15, 1, 2, 3 };
            BubbleSort(ToSort);
            Console.WriteLine(string.Join(", ",ToSort));
            Console.ReadLine();
        }

        /// <summary>
        /// Fibonacci method
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static int fid(int i)
        {
            if (i <= 2) return 1;
            return fid(i - 2) + fid(i - 1);
        }

        /// <summary>
        /// Method to expotentail number
        /// </summary>
        /// <param name="baseNum"></param>
        /// <param name="powNum"></param>
        /// <returns></returns>
        static int pow(int baseNum, int powNum)
        {
            int result = 1;
            for (int i = 0; i < powNum; i++) result = result * baseNum;
            return result;
        }

        /// <summary>
        /// Method to swap elements
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Swap(ref int a, ref int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Sort method N(N-1)
        /// </summary>
        /// <param name="Array"></param>
        static void BubbleSort(int[] Array)
        {
            int size = Array.Length;
            int swapped = 0;
            for(int i=0; i< size-1; ++i)
            {
                swapped = 0;
                for(int j=0; j<size-i-1; ++j)
                {
                    if (Array[j] < Array[j + 1])
                    {
                        swapped = 1;
                        Swap(ref Array[j], ref Array[j + 1]);
                    }
                }
                if (swapped == 0) break;
            }
               
        }
        /// <summary>
        /// Method to get all value divided by value
        /// </summary>
        /// <param name="DivideBy"></param>
        /// <param name="StartNr"></param>
        /// <param name="EndNr"></param>
        /// <returns></returns>
        static IEnumerable<int> GetValDiv(int DivideBy, int StartNr, int EndNr)
        {
            for(int i=StartNr; i<=EndNr; i++)
            {
                if(i % DivideBy == 0) yield return i; 
            }
        }
        static List<int> GetValDivV2(int DivideBy, int StartNr, int EndNr)
        {
            var result = new List<int>();
            for (int i = StartNr; i <= EndNr; i++)
            {
                if (i % DivideBy == 0) result.Add(i);
            }
            return result;
        }

    }
}
