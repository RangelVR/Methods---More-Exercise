using System;

namespace _02.Center_Point
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
                GetClosetPoit(x, y, ref result, ref sum);
            }
            Console.WriteLine($"({string.Join(", ", result)})");
        }


        static void GetClosetPoit(double x, double y, ref double[] result, ref double sum)
        {
            double currSum = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (currSum < sum)
            {
                sum = currSum;
                result = new double[2] { x, y };
            }
        }

    }
}
========================================================================================================
//using System;

//namespace _02.Center_Point
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double x = 0;
//            double y = 0;
//            PrintClosestPointToZero(x, y);
//        }


//        static void PrintClosestPointToZero(double x, double y)
//        {
//            double[] result = new double[2];
//            double closestPoint = double.MaxValue;
//            int counter = 0;

//            for (int i = 0; i < 2; i++)
//            {
//                x = double.Parse(Console.ReadLine());
//                y = double.Parse(Console.ReadLine());
//                double[] arr = new double[2] { x, y };

//                double hypotenuse = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

//                if (hypotenuse < closestPoint)
//                {
//                    closestPoint = hypotenuse;
//                    result = arr;
//                }
//                counter++;
//                if (counter == 2)
//                {
//                    Console.WriteLine($"({string.Join(", ", result)})");
//                }
//            }
//        }

//    }
//}
