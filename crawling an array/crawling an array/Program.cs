using System;

namespace crawling_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] myNumbers =
            {
                2.5, -10000, 5, 76, 3, -2, 0, 13, -651, 33.33, 1
            };
            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }
        }
    }
}
