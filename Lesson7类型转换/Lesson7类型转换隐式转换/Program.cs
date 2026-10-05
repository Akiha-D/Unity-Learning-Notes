using System;

namespace Lesson7
{
    class Program       
    {
        static void Main(string[] age)  
        {
            // sbyte int short long
            //有符号
            sbyte sb = 1;
            int i = 1;
            short s = 1;
            long l = 1;
            
            //大范围装小范围
                // long->int->short->sbyte
            l = i;
            
            //不能用小范围装大范围 
            
            //无符号 ulong uint ushort byte
            
            ulong ul = 1;
            uint ui = 1;
            ushort us = 1;
            byte ub = 1;

            ul = ui;
            ul = us;
            ul = ub;
            
            //浮点数 decimal double float
            
            decimal de = 1.1m;
            
            double d = 1.1;
            
            float f = 1.1f;

            //decimal 这个类型 没有办法用隐形转换的形式 去存储double float
            d = f;
            
            //特殊类型 bool char string 
            //他的之间 不存在隐式转换
            
            //不同大类型之间的转换
            //无符号和有符号
            //有符号的变量 是不能隐形转换成 无符号的
            //i = ui;
            //有符号装无符号
            s = ub;
            l = ui;
            //ui = i;

            //浮点数和整数（有，无符号）之间
            f = ui;
            f = i;
            //浮点数是可以装载任何类型的整数的
            de = i;
            de = ui;
            //decimal不能隐式存储float和double 
            //但是能隐式的存储整形
            float a11 = 11111111111111111;
            Console.WriteLine(a11);
            
            //特殊类型和其他类型之间
            
            bool bo =  true;
            //bool 没有办法和其他类型相互隐式转换

            char c = 'a';
            string st = "a";
            // c = i;
            // c = ui;
            // c = f;
            
            //char没有办法和其他类型相互隐式转换

            i = c;
            ui = c;
            de = c;
            f = c;
            
            char name = '邓';
            int a;
            a = name;
            Console.WriteLine(a);

        }
    }
}