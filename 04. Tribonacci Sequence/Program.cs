using System;

namespace Tribonacci_Sequence_More_Exercise_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] tribonacci = new int[lenght];
            Calculation(tribonacci);

            for (int i = 0; i < lenght; i++)
            {
                Console.Write($"{tribonacci[i]} ");
            }
        }

        
        private static void Calculation(int[] tribonacci)
        {
            tribonacci[0] = tribonacci[1] = 1;
            tribonacci[2] = 2;

            for (int i = 3; i < tribonacci.Length; i++)
            {
                tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
            }
        }
    }
}
