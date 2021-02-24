using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System.Net.Http.Headers;
using System.Collections.Concurrent;
using System.Runtime.Serialization;
using System.Data;
using Internal;
using System.Reflection.Emit;
using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //생성자 호출
            var abbrs = new Abbreviations();
            
            // Add 메서드 호출
            abbrs.Add("IOC", "국제 올림픽 위원회");
            abbrs.Add("NPT", "핵확산방지조약");

            // 인덱서를 사용한 예
            var names = new[] {"WHO", "FIFA", "NPT"};
            foreach (var name in names)
            {
                var fulname = abbrs[name];
                if (fullname == null)
                    Console.WriteLine("{0}을(를) 찿을 수 없습니다.", name);
                else
                    Console.WriteLine("{0} = {1}", name, fullname);
            }
            Console.WriteLine();

        }
    }
}
