using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> {12, 98,34,32, 41, 12,13,22};
            var names = new List<string> {
                 "Seoul", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Q_1(numbers);
            Console.WriteLine("-----");
            Q_2(numbers);
            Console.WriteLine("-----");
            Q_3(numbers);
            Console.WriteLine("-----");
            Q_4(numbers);
            Console.WriteLine("-----");
            Q_5(names);
            Console.WriteLine();
            Q_6(names);
            Console.WriteLine();
            Q_7(names);
            Console.WriteLine();
            Q_8(names);
        }

        private static void Q_1(List<int> numbers)
        {
            var exist = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
            if (exist)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
        private static void Q_2(List<int> numbers)
        {
            numbers.ForEach(n => Console.WriteLine(n / 2.0));
        }
        private static void Q_3(List<int> numbers)
        {
            foreach(var number in numbers.Where(x => x >= 50))
            {
                Console.WriteLine(number);
            }
        }
        private static void Q_4(List<int> numbers)
        {
            var list = numbers.Select(numbers => numbers*2).ToList();
            foreach(var n in list)
                Console.WriteLine(n);
        }
        private static void Q_5(List<string> names)
        {
            Console.WriteLine("도시 이름을 입력하세요, 빈 행이 입력되면 종료 합니다.");
            while(true)
            {
                var line = Console.ReadLine();
                if(string.IsNullOrEmpty(line))
                    break;
                var index = names.FindIndex(s => s == line);
                Console.WriteLine(index);
            }
        }
        private static void Q_6(List<string> names)
        {
            var count = names.Count(s => s.Contains("o"));
            Console.WriteLine(count);
        }
        private static void Q_7(List<string> names) {
            {
                var selectedCity = names.Where(s => s.Contains("o"))
                                        .ToArray();
                foreach(var name in selectedCity)
                    Console.WriteLine(name);
            }
        }
        private static void Q_8(List<string> names)
        {
            var selectedCity = names.Where(s => s.StartsWith("B"))
                                    .Select(s => s.Length);
            foreach(var length in selectedCity)
                Console.WriteLine(length);
        }
    }
}
