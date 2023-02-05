using System.Linq;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] tribonacciSequence = new int[Math.Max(n, 3)];

            GetTribonacciSequence(ref tribonacciSequence, n);
            PrintTribonacciSequence(tribonacciSequence, n);
        }

        static void GetTribonacciSequence(ref int[] arr, int n)
        {
            arr[0] = arr[1] = 1;
            arr[2] = 2;

            for (int i = 3; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
            }
            //for (int i = 0; i < n - 3; i++)
            //{
            //    int[] arr = tribonacciSequence.Skip(i).Take(3).ToArray();
            //    tribonacciSequence[i + 3] = arr.Sum();
            //}
        }

        static void PrintTribonacciSequence(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
==============================================================================================================

//using System;

//namespace _04.Tribonacci_Sequence
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[Math.Max(n, 3)];
//            arr[0] = arr[1] = 1;
//            arr[2] = 2;

//            for (int i = 3; i < n; i++)
//            {
//                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
//            }
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write(arr[i] + " ");
//            }
//        }

//    }
//}
