using System;
using System.Linq;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] firstPoints = new double[2];
            double[] secondPoints = new double[2];
            double sum = double.MinValue;


            for (int i = 0; i < 2; i++)
            {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());
                GetTheClosetPoint(x1, y1, x2, y2, firstPoints, secondPoints, ref sum);
            }
            Console.WriteLine($"({string.Join(", ", secondPoints)})({string.Join(", ", firstPoints)})");
        }


        static void GetTheClosetPoint(double x1, double y1, double x2, double y2,
            double[] firstPoints, double[] secondPoints, ref double sum)
        {
            //double a = 0;
            //double b = 0;
            //double c = 0;

            //if (x1 != 0 && x2 != 0 && y1 != 0 && y2 != 0)
            //{
                
            //}
            a = Math.Abs(x1 - x2);
            b = Math.Abs(y1 - y2);
            c = Math.Sqrt(Math.Pow(a, 2) - Math.Pow(b, 2));


            if (c > sum)
            {
                sum = a;

                firstPoints[0] = x1;
                firstPoints[1] = y1;
                secondPoints[0] = x2;
                secondPoints[1] = y2;
            }

        }
    }
}
