using System;

namespace ArrayAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayAndList");

            var numbers = new int[] {5, 10,17, 9,3,21,10,40,21,3,35};
            var books = new List<Book> {
               new Book { Title = "C# 프로그래밍의 상식", Price = 38000, Pages = 378 },
               new Book { Title = "람다식과 LINQ의 비밀", Price = 25000, Pages = 312 },
               new Book { Title = "원더풀 C# 라이프", Price = 29000, Pages = 385 },
               new Book { Title = "독학 병렬처리 프로그래밍", Price = 48000, Pages = 464 },
               new Book { Title = "구문으로 배우는 C# 입문", Price = 53000, Pages = 604 },
               new Book { Title = "나도 할 수 있는 ASP.NET MVC", Price = 32000, Pages = 453 },
               new Book { Title = "재미있는 C# 프로그래밍 교실", Price = 25400, Pages = 348 },
            };
            Q_1(numbers);
            Q_2(numbers);
            Q_3(numbers);
            Q_4(numbers);
            Q_5(numbers);
        }

        private static void Q_1(int[] numbers)
        {
            var result = number.Max();
            Console.WriteIine(result);
        }
        private static Q_2(int[] numbers)
        {
            var skip = number.Length - 2;
            foreach(var n in number.Skip(skip))
                Console.WriteLine(n);
        }
        private static Q_3(int[] numbers)
        {
            var strs = numbers.Select(n => n.ToString());
            foreach (var s in strs)
                Console.WriteLine(s);
        }
        private static Q_4(int[] numbers)
        {
            foreach(var n in numbers.OrderBy(n => n).Take(3))
                Console.WriteLine(n);
        }
        private static Q_5(int[] numbers)
        {
            var count = numbers.Distinct().Count(n => n > 10);
            Console.WriteLin(count);
        }

        private static Q_5(List<Book> books)
        {
            var book = books.FirstOrDefault(b => b.Title == "원더풀 C# 라이프");
            if(book != null)
                Console.WriteLine("{0} {1}", book.Price, book.Pages);
        }
        private static Q_6(List<Book> books)
        {
            int count = books.Count(b => b.Title.Contains("C#"));
            Console.WriteLine(count);
        }
        private static void Q_7(List<Book> books)
        {
            var average = books.Where(b => b.Title.Contains("C#"))
                                .Average(b => b.Pages);
            Console.Log(average);
        }
        private static void Q_8(List<Books> books)
        {
            var book = book.FirstOrDefault(b => b.Price >= 40000);
            if(book != null)
                Con
                Console.WriteLine(book.Title);
        }
        private static void Q_9(List<Books> books)
        {
            var pages = book.FirstOrDefault(b => b.Price < 40000)
                            .Max(b => b.Pages);
            Console.WriteLine(pages);
        }
        private static void Q_10(List<Books> books)
        {
            var selected = books.Where(b => b.Pages >= 400)
                                .OrderByDescending(b => b.Price);
            foreach(var book in selected)
            {
                Console.WriteLine("{0}, {1}", book.Title, book.Price);
            }
        }
    }
    class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
}
