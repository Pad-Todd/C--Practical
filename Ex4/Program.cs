using System;
using System.Text;
using System.Linq;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q_1();
            // Q_2();
            Q_3();
        }

        static void Q_1()
        {
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();
            if(string.Compare(s1,s2, ignoreCase:true) == 0)
                Console.WriteLine("같다");
            else
                Console.WriteLine("같지 않다.");
        }
        static void Q_2()
        {
            var line = Console.ReadLine();
            int num;
            if(int.TryParse(line, out num))
            {
                Console.WriteLine("{0:#,#}", num);
            }
            else
            {
                Console.WriteLine("숫자값이 문자열이 아닙니다.");
            }
        }
        static void Q_3()
        {
            var text = "Jackdaws love my big sphinx of quartz";
            int space = text.Count(c => c == ' ');
            Console.WriteLine("공백 수:{0}", space);
            Console.WriteLine("------------------");

            var replace = text.Replace("big", "small");
            Console.WriteLine(replace);
            Console.WriteLine("------------------");

            var count = text.Split(" ").Length;
            Console.WriteLine(count);
            Console.WriteLine("------------------");

            var words = text.Split(' ')
                            .Where(s => s.Length <= 4);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            var array = text.Split(' ')
                            .ToArray();
            if(array.Length > 0)
            {
                var sb = new StringBuilder(array[0]);
                foreach(var word in array.Skip(1))
                {
                    sb.Append(' ');
                    sb.Append(word);
                }
                var clone = sb.ToString();
                Console.WriteLine(clone);
            }
        }
    }

}

    
