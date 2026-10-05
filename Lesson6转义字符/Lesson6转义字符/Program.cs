using System;

namespace Lesson6
{
    class Program       
    {
        static void Main(string[] age)
        {
            //string name = "s""";
            // 需要转义字符
            string name = "\"a\"";
                Console.WriteLine(name);

                string a1 = "\'a\'";
                Console.WriteLine(a1);
            //换行
            string a2 = "re\nee";
            Console.WriteLine(a2);
            
            //斜杠
            string a3 = "a\\a";
            Console.WriteLine(a3);
            
            string a4 = "a\ta";
            Console.WriteLine(a4);

            string a5 = "ab\bcd";
            Console.WriteLine(a5);
            
            string a6 = "abc\0d";
            Console.WriteLine(a6);
            
            string a7 = "\a";
            Console.WriteLine(a7);
            
            string a8 = @"z\zz";
            Console.WriteLine(a8);
            
            string a9 = @"re\nee";
            Console.WriteLine(a9);
            
            string a10 = "我是小明\n我今年18";
            Console.WriteLine(a10);
        }
    }
}