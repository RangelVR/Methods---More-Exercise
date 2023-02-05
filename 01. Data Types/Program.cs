namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();

            switch (type)
            {
                case "int":
                   int number = int.Parse(input);
                    GetTypeAndPrint(type, number);
                    break;
                case "real":
                    double realNnum = double.Parse(input);
                    GetTypeAndPrint(type, realNnum);
                    break;

                default:
                    GetTypeAndPrint(type, input);
                    break;
            }
        }

        static void GetTypeAndPrint(string type, string input)
        {
            Console.WriteLine("${0}$", input);
        }

        static void GetTypeAndPrint(string type, int number)
        {
            Console.WriteLine(number * 2);
        }

        static void GetTypeAndPrint(string type, double realNum)
        {
            Console.WriteLine($"{(realNum * 1.5d):f2}");
        }
    }
}
