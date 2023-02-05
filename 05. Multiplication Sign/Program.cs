namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];

            for (int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            PrintMultiplicationSign(arr);
        }

        static void PrintMultiplicationSign(int[] arr)
        {
            int minusCounter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    minusCounter++;
                }
            }

            if (arr.Any(x => x == 0))
            {
                Console.WriteLine("zero");
            }
            else
            {
                if (minusCounter == 1 || minusCounter == 3)
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    Console.WriteLine("positive");
                }
            }
            
        }
    }


//    using System;

//namespace _05.Multiplication_Sign
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                int n1 = int.Parse(Console.ReadLine());
//                int n2 = int.Parse(Console.ReadLine());
//                int n3 = int.Parse(Console.ReadLine());

//                PrintPositiveOrNegative(n1, n2, n3);
//            }


//            static void PrintPositiveOrNegative(int n1, int n2, int n3)
//            {
//                if (n1 == 0 || n2 == 0 || n3 == 0)
//                {
//                    Console.WriteLine("zero");
//                }
//                else if (n1 < 0 && n2 < 0 && n3 < 0)
//                {
//                    Console.WriteLine("negative");
//                }
//                else if (n1 < 0 && n2 < 0 || n1 < 0 && n3 < 0 || n2 < 0 && n3 < 0)
//                {
//                    Console.WriteLine("positive");
//                }
//                else if (n1 < 0 || n2 < 0 || n3 < 0)
//                {
//                    Console.WriteLine("negative");
//                }
//                else
//                {
//                    Console.WriteLine("positive");
//                }
//            }
//        }
//    }

}
