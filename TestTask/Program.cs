using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestTask
{
    internal class Program
    {
        class test
        {
            public int abdc { get; set; }
            public string efg { get; set; }
        }
        static void Main(string[] args)
        {
            string str1 = "NetFusion";
            string str2 = "NETFSUSION";

            if (str1 == str2)
            {
                Console.WriteLine("AA");
            }
            int[] MyFriend = { 1, 2, 3, 4, 5 };
            int[] YourFriend = { 1, 5, 6, 7, 8 };
            var OurFriend = MyFriend.Intersect(YourFriend).ToList();
            OurFriend.ForEach(Console.WriteLine);

            var ss = string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);

            var pass = "MXFhejJ3c3ghUUFaQFdTWA==";
            byte[] data = Convert.FromBase64String(pass);
            pass = Encoding.UTF8.GetString(data);
            Console.WriteLine(pass);

        }

        class C1
        {
            public string Data = "";
        }
        class C2
        {
            public string Data = "";
            public string Test = "";
            public static bool operator ==(C2 x, C2 y)
            {
                return x.Data == y.Data;
            }
            public static bool operator !=(C2 x, C2 y)
            {
                return x.Data != y.Data;
            }
        }
    }
}
