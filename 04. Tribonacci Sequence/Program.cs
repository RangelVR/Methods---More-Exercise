using System;
using System.Linq;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[Math.Max(n, 3)];

            GetTribonacciSequence(n, arr);

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        static void GetTribonacciSequence(int n, int[] arr)
        {
            arr[0] = arr[1] = 1;
            arr[2] = 2;

            for (int i = 3; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
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
