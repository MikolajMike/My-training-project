using System;
using System.Collections.Generic;

namespace TrainingApp
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Numbers divide by 5: "+string.Join(", ", GetValDiv(5,1,100)));
            //Console.WriteLine("Numbers divide by 10: "+string.Join(", ", GetValDivV2(10, 1, 100)));
            int[] toSort = { 10, 30, 19, 15, 1, 2, 3 };
            BubbleSort(toSort);
            Console.WriteLine(string.Join(", ",toSort));
            Console.WriteLine(string.Join(", ", ChangeNameOfDivVal(3, 1, 100, "Fuzz")));
            Console.WriteLine(GetDistReso(72, (float)1/10, Math.PI));

            //Console.ReadLine();
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
        static void BubbleSort(int[] array)
        {
            int size = array.Length;
            int swapped = 0;
            for(int i=0; i< size-1; ++i)
            {
                swapped = 0;
                for(int j=0; j<size-i-1; ++j)
                {
                    if (array[j] < array[j + 1])
                    {
                        swapped = 1;
                        Swap(ref array[j], ref array[j + 1]);
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
        static IEnumerable<int> GetValDiv(int divideBy, int startNr, int endNr)
        {
            for(int i=startNr; i<=endNr; i++)
            {
                if(i % divideBy == 0) yield return i; 
            }
        }
        static List<int> GetValDivV2(int divideBy, int startNr, int endNr)
        {
            var result = new List<int>();
            for (int i = startNr; i <= endNr; i++)
            {
                if (i % divideBy == 0) result.Add(i);
            }
            return result;
        }

        /// <summary>
        /// Change the divided value to any name
        /// </summary>
        /// <param name="divideBy"></param>
        /// <param name="startNr"></param>
        /// <param name="endNr"></param>
        /// <param name="changeTo"></param>
        /// <returns></returns>
        static IEnumerable<string> ChangeNameOfDivVal(int divideBy, int startNr, int endNr, string changeTo)
        {
            for(int i=startNr; i<=endNr; i++)
            {
                if (i % divideBy == 0) yield return changeTo;
                else yield return Convert.ToString(i); 
            }
        }

        static double GetDistReso(double diameter, double gearRatio, double Pi)
        {
            return diameter * gearRatio * Pi;
        }
    }
}
