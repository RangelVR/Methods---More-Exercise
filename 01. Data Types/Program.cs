using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string data = Console.ReadLine();

            if (dataType == "int")
            {
                PrintDataInt(dataType, data);
            }
            else if (dataType == "real")
            {
                PrintDataReal(dataType, data);
            }
            else if (dataType == "string")
            {
                Console.WriteLine($"${data}$");
            }
        }


        static void PrintDataInt(string dataType, string data) 
        {
            int number = int.Parse(data);
            Console.WriteLine(number * 2);
        }


        static void PrintDataReal(string dataType, string data) 
        {
            double number = double.Parse(data);
            double sum = number * 1.5;
            Console.WriteLine($"{sum:f2}");
        }

    }
}
=======================================================================================
//using System;

//namespace _01.Data_Types
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            string data = Console.ReadLine();

//            if (input == "string")
//            {
//                Console.WriteLine($"${data}$");
//            }
//            PrintIntAndDoubleResult(input, data);
//        }

//        static void PrintIntAndDoubleResult(string input, string data)
//        {
//            switch (input)
//            {
//                case "int":
//                    int resultInt = int.Parse(data) * 2;
//                    Console.WriteLine(resultInt);
//                    break;

//                case "real":
//                    double resultDouble = double.Parse(data) * 1.5;
//                    Console.WriteLine($"{resultDouble:f2}");
//                    break;
//            }
//        }

//    }
//}
