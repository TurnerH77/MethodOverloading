using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2,3));
            Console.WriteLine(Add(2.3m, 2.4m));
            Console.WriteLine(Add(10, 30, true));
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool z)
        {
            var sum = x + y;

            if(z == true && (x+y) > 1)
            {
                return $"{sum} dollars.";
            }
            else if(z == true && (x+y) == 1)
            {
                return $"{sum} dollar.";
            }
            else
            {
                return sum.ToString();
            }
        }

    }
}
