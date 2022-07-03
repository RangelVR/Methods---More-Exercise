using System;
using System.Linq;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 1, 2};
            int n = int.Parse(Console.ReadLine());

            GetTribonacciSequence(n, arr);
        }

        static void GetTribonacciSequence(int n, int[] arr)
        {
            int sum = 0;

            if (n <= 2)
            {
                IfNlessThen2(n);
            }
            else
            {
                Console.Write($"{string.Join(" ", arr)} ");
                for (int i = 0; i < n - 3; i++)
                {
                    sum = arr.Sum();
                    Console.Write($"{sum} ");
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[arr.Length - 1] = sum;
                }
            }
        }

        static void IfNlessThen2(int n) 
        {
            if (n == 1)
            {
                Console.WriteLine($"1");
            }
            else if (n == 2)
            {
                Console.WriteLine($"1 1");
            }
        
        }

    }
}
