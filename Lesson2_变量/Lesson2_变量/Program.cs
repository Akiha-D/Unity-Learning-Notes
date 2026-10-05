using System;

namespace Program
{
    class Program
    {
        static void Main(string[] age)
        {
            
            #region MyRegion

            

            #endregion、

            int a1 = 1; //int范围 -21亿 ~ 21亿多
            
            short  a2 = 1;

            sbyte a3 = -128;
            sbyte a4 = 127;// sbyte范围-128 ~ 127
            Console.WriteLine(a1);
            //折叠code #region #endregion 只会在编辑是所用
            
            byte a5 = 0;
            Console.WriteLine(a5);

            float a = 0.5555555555f;
            Console.WriteLine(a);
            
            bool b1 = true;
            bool b2 = false;
            
            Console.WriteLine(b1);
            Console.WriteLine(b2);

            char c = '字';
            Console.WriteLine(c);
            string str = "sbsbsb114514";
            Console.WriteLine(str);

            int i = 11;
            Console.WriteLine(i);
            i = 14;
            Console.WriteLine(i);

            int a6;
            a6 = 5;
            Console.WriteLine(a6);

            int math = 80;
            int yuwen = 78;
            int english = 98;
            Console.WriteLine(math );

            string name = "D";
            byte age1 = 19;
            bool sex = true;
            float hight = 1.114514f;
            float wight = 1.1919810f;
            string home = "NICAI";  

        }
    }
}