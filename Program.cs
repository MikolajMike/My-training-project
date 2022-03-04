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
            //int[] toSort = { 10, 30, 19, 15, 1, 2, 3 };
            //BubbleSort(toSort);
            //Console.WriteLine(string.Join(", ",toSort));
            //Console.WriteLine(string.Join(", ", ChangeNameOfDivVal(3, 1, 100, "Fuzz")));
            //Console.WriteLine(GetDistReso(72, (float)1/10, Math.PI));

            selMethod methToChoose = new selMethod();
            Console.WriteLine("Select method u want to use:");
            for (int i = 1; i < Enum.GetNames(typeof(selMethod)).Length; i++)
            {
                Console.WriteLine($"{i}. Choose method {methToChoose = (selMethod)i}"); // can change to Enum.GetNames(typeof(selMethod)).GetValue(i)
            }
            selMethod selMeth = (selMethod)Enum.Parse(typeof(selMethod), Console.ReadLine());

            switch (selMeth)
            {
                case selMethod.fib:
                    Console.WriteLine("Type the fib number:");
                    Console.WriteLine(fid(Convert.ToInt32(Console.ReadLine())));
                    break;
                case selMethod.pow:
                    int baseNum, powNum;
                    Console.WriteLine("Type the number u want to pow:");
                    Console.WriteLine("Type base number");
                    baseNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Type pow number");
                    powNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Convert.ToString(pow(baseNum,powNum)));
                    break;
                case selMethod.swap:
                    int firstNumber, secondNumber;
                    Console.WriteLine("Swap position of two numeric value");
                    Console.WriteLine("Type first number:");
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Type second number:");
                    secondNumber = Convert.ToInt32(Console.ReadLine());
                    Swap(ref firstNumber, ref secondNumber);
                    Console.WriteLine($"First number value: {firstNumber}, Second number value: {secondNumber}");
                    break;
                case selMethod.bubbleSort:
                    break;
                case selMethod.getValDiv:
                    break;
                case selMethod.getValDiv2:
                    break;
                case selMethod.changeNameOfDivVal:
                    break;
                case selMethod.getDistReso:
                    break;
                default:
                    Console.WriteLine("Type wrong method number. Type again:");
                    Main(args);
                break;
            }
                
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

        /// <summary>
        /// Calculate the distance resolution
        /// </summary>
        /// <param name="diameter"></param>
        /// <param name="gearRatio"></param>
        /// <param name="Pi"></param>
        /// <returns></returns>
        static double GetDistReso(double diameter, double gearRatio, double Pi)
        {
            return diameter * gearRatio * Pi;
        }

        //static int CheckIfValIsNum(string Value)
        //{
        //    if (int.TryParse(Value, out int result))
        //    {
        //        return result;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Typed value is not a number");
        //        return 9999;
        //    }
        //
        //
        //}
    }
}
