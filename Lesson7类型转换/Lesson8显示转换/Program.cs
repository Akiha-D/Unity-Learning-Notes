using System;

namespace Lesson8
{
    class Program       
    {
        static void Main(string[] age)
        {
            sbyte sb = 1;
            short s = 1;
            int i = 400000;
            long l = 1;
            
            //括号强转
            //s = i;会报错 所以
            
            s = (short)l;
            sb = (sbyte)l;
            s = (short)i;
            Console.WriteLine(s);
            i = (int)l;
            
            
            //无符号
            byte b = 1;
            uint ui = 1;
            b = (byte)ui;
            
            //浮点数之间
            float f = 1.1f;
            double d = 1.123456789f;

            //f = d;
            f =(float)d;
            
            Console.WriteLine(f);
            
            //无符号和有符号
            uint ui2 = 1;
            int  i2 = -1;

            //ui2 = i2;
            ui2 =(uint)i2;
            Console.WriteLine(ui2);
            
            //浮点和整数型 (浮点数转成整数时 会直接抛弃小数点后的小数)
            int  i3 = -1;
            i2 = (int)1.24f;
            i3 = (int)1.6f;
            Console.WriteLine(i2);
            Console.WriteLine(i3);
            
            //char的数值类型

            i2 = 'a';
            char c = (char)i2;
            Console.WriteLine(c);
            
            // bool 和 string

            // bool bo = true;
            // int i4 = -1;
            // i4 = (int)bo;
            // string st = "aa";
            // i4 = (int)st;
            //bool 和 string 是不能通过括号的方式强制转换的
            
            //知识点2 Parse法

            // //int i5 = 'a';
            // string str = "abcd";
            // int i4 = int.Parse(str);
             int i5 = int.Parse("123");
             Console.WriteLine(i5);
            //
            // int i6 = int.Parse("111.11");
            // Console.WriteLine(i6);
            
            //字符串必须能够转成相应类型 否则报错
            
            short i6 = short.Parse("1234");
            Console.WriteLine(i6);
            
            Console.WriteLine(sbyte.Parse("123"));

            //无符号
            Console.WriteLine(byte.Parse("123"));
            Console.WriteLine(uint.Parse("123"));
            Console.WriteLine(ushort.Parse("123"));
            Console.WriteLine(ulong.Parse("123"));
           
            
            //浮点数
            
            float f3 = float.Parse("1.1");
            double d3 = double.Parse("1.12");
            
            
            Console.WriteLine(float.Parse("123456"));
            Console.WriteLine(float.Parse("123.123"));
            
            //特殊类型
            
            bool b5 = bool.Parse("true");
            Console.WriteLine(b5);
            
            char c5 = char.Parse("a");
            Console.WriteLine(c5);
            
            //知识点3 convert法
            
            int i7 = Convert.ToInt32("1234");
            Console.WriteLine(i7);
            i7 = Convert.ToInt32(1.23f);
            Console.WriteLine(i7);
            i7 = Convert.ToInt32(1.73f);
            Console.WriteLine(i7);
            
            //convert 精度比括号强换要好一点 会四舍五入
            
            //转字符串 如果把字符串转对应类型 那字符串一定要合法合规
            long l7 = Convert.ToInt64("1234567");
            
            
            //把bool类型也可以转成 数值类型 true对应 1 false 对应 0 
            i7 = Convert.ToInt32(true);
            Console.WriteLine(i7);
            i7 = Convert.ToInt32(false);
            Console.WriteLine(i7);
            
            //Char类型也可以
            i7 = Convert.ToInt32('a');
            Console.WriteLine(i7);
            i7 = Convert.ToInt32('A');
            Console.WriteLine(i7);
            
            //每一个类型都存在对应的Convert中的方法
            
            //有符号
            sbyte sb1 = Convert.ToSByte("123");
            short sh = Convert.ToInt16("1234");
            int i9 = Convert.ToInt32("123456");
            long l9 = Convert.ToInt64("1234567");
            
            //无符号
            byte b1 = Convert.ToByte("123");
            ushort us1 = Convert.ToUInt16("123");
            uint ui1 = Convert.ToUInt32("123");
            ulong l1 = Convert.ToUInt64("1234567");
            
            //浮点数
            float f1 = Convert.ToSingle("1.1");
            double d1 = Convert.ToDouble("1.12");
            decimal dec1 = Convert.ToDecimal("1.12");
            
            //特殊类型
            bool b2 = Convert.ToBoolean("true");
            char c2 = Convert.ToChar("1");
            
            
            string s3 = Convert.ToString(123);

            //知识点4 其他类型转string 

            string s4 = 1111.ToString();
            
            Console.WriteLine(s4);

            string s5 = true.ToString();
            Console.WriteLine(s5);
            
            string s6 = 'a'.ToString();
            Console.WriteLine(s6);

            int a11 = 3;
            s6 = a11.ToString();
            bool b11 = true;
            s5 = b11.ToString();
            
            //当进行字符串拼接时，就自动会调用ToString 转成string
            Console.WriteLine("sb" + 3 + true );
        
            //"sb"必须要有 否则int+bool会报错 + 从左到右扫，遇到第一个 string 之后，后面就全是拼接了；在那之前还是严格的数值运算。
            


        }
    }
}