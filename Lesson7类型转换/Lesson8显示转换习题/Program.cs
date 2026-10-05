using System;

namespace Lesson8Exercise
{
    class Program       
    {
        static void Main(string[] age)
        {
            //1.括号强转 
            //低精度装高精度

            int i1 = 5;
            long l1 = 6;
            i1 = (int)l1;

            float f = 1.1f;
            double d = 1.123456789f;
            //f = d
            
            f = (float)d;
            Console.WriteLine(f);
            //强转会丢失精度 
            
            Console.WriteLine(i1);
            int  i2 = -1;
            int  i3 = -1;
            i2 = (int)1.24f;
            i3 = (int)1.6f;
            Console.WriteLine(i2);
            
            sbyte sb = 1;
            short s = 1;
            sb = (sbyte)s;
            Console.WriteLine(sb);


            //2.Pares法
            //转字符串
            int i5 = int.Parse("111");
            Console.WriteLine(i5);
            
            //3.Convert法
            
            int i8 = Convert.ToInt16("111"); //short
            Console.WriteLine(i8);

            int i9 = Convert.ToInt32(1.1f);
            Console.WriteLine(i9);
            
            int i10 = Convert.ToInt32(1.6f);
            Console.WriteLine(i10); 
            //Convert 会更精准 会四舍五入
            
            string st1 = Convert.ToString(123123123);
            Console.WriteLine(st1);
            
            //只有Convert法能将其他类型转成string的 
            //4.ToString 用于拼接打印 
            
            string s1 = 111.ToString();
            
            Console.WriteLine("sb"+ 111);
            
            //题2 24069 转成字符 并打印
            char c1 = (char)24069;
            Console.WriteLine(c1);
            
            c1 =Convert.ToChar(37011);
            Console.WriteLine(c1);
            
            int i12;
            //Exercise3 提示用户输入姓名，语文 ，数学， 英语成绩 把成绩用整形变量存储
            Console.WriteLine("请输入姓名");
            String str3 = Console.ReadLine();   
            //int yuWen = int.Parse(str3);
            
            Console.WriteLine("请输入语文成绩");
            string str4 = Console.ReadLine();
            int i13= Convert.ToInt32(str4);
            
            Console.WriteLine("你的语文成绩" + i13);
            
            
            Console.WriteLine("请输入数学成绩");
            string str5 = Console.ReadLine();
            int i14= Convert.ToInt32(str5); 
            Console.WriteLine("你的数学成绩" + i14);
            
            
            Console.WriteLine("请输入英语成绩");
            string str6 = Console.ReadLine();
            int i15= Convert.ToInt32(str6);
            Console.WriteLine("你的英语成绩" + i15);
            
            
            


            Console.ReadKey();

        }
    }
}