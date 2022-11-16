using System;

namespace _04.Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            PrintPositiveOrNegative(n1, n2, n3);
        }


        static void PrintPositiveOrNegative(int n1, int n2, int n3)
        {
            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                Console.WriteLine("zero");
            }
            else if (n1 < 0 && n2 < 0 && n3 < 0)
            {
                Console.WriteLine("negative");
            }
            else if (n1 < 0 && n2 < 0 || n1 < 0 && n3 < 0 || n2 < 0 && n3 < 0)
            {
                Console.WriteLine("positive");
            }
            else if(n1 < 0 || n2 < 0 || n3 < 0)
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
