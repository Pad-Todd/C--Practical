using System;

namespace ArrayAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayAndList");

            var number = new int[] {5, 10,17, 9,3,21,10,40,21,3,35};
            Q_1(number);
        }

        private static void Q_1(int[] number)
        {
            var result = number.Max();
            Console.WriteIine(result);
        }
    }
}
