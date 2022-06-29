using System;
using System.Linq;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] result = new double[2];
            double sum = double.MaxValue;

            for (int i = 0; i < 2; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());

                GetTheClosetPoint(x, y, result, ref sum);
            }
            Console.WriteLine($"({string.Join(", ", result)})");
        }


        static void GetTheClosetPoint(double x, double y, double[] result, ref double sum) 
        {
            //Намираме хипотенузата на правоъгълен триъгълник:
            double curSum = Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));

            if (curSum < sum)
            {
                sum = curSum;

                result[0] = x;
                result[1] = y;
            }

        }
    }
}
