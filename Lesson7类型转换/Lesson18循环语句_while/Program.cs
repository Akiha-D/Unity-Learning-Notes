using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Lesson18
{
    class Program       
    {
        static void Main(string[] age)
        {   
            Console.WriteLine("Lesson 18 循环语句 while");

            #region 1.作用
            // 让循环执行的代码 可以不停循环执行某一代码块的内容
            // 条件分支语句 是让代码产生分支
            // 循环语句 是 让代码可以被反复执行
            

            #endregion

            #region 2.语法相关

            // while (bool类型的值)// bool类型变量 条件运算符 逻辑运算符 
            //
            // {
            //  //当满足条件时 就会执行while语句块中的 内容
            //  //当代码逻辑执行完 会回到while循环开头
            //  //再次执行条件判断
            // }
            
            //死循环
            //就不停的执行循环中的逻辑
            //死循环 只有在目前我们学习 控制台程序时 会频繁使用
            //之后进入unity 之后 基本不会使用死循环
            //可能因为内存问题 造成程序卡顿崩溃
            //可能造成程序卡死  
            
            // while (true)
            // {
            //     Console.WriteLine("yep");
            // } 
            //死循环
            

            #endregion

           

            int i = 0;
            while (i < 10)
            {
                ++i;
                Console.WriteLine(i);
            }



            #region 3.嵌套使用

            // 不仅可以嵌套if switch还可以嵌套while
            int a2 = 0;
            int b = 0;
            while (a2 < 10)
            {
                ++a2;
                Console.WriteLine(a2);
                while (b < 10)
                {
                    ++b;
                    Console.WriteLine(b);
                }
            }

            a2 = 0;
            b = 0;
            while (a2 < 10)
            {
                ++a2;
                Console.WriteLine(a2);
                if (b < 10)
                {
                    ++b;
                    Console.WriteLine(b);
                }
            }





            #endregion

            #region 4.流程控制关键词
            //作用 : 控制循环逻辑的关键词
            //break : 跳出循环
            //continue : 回到循环开始 继续执行
            while (true)
            {
                Console.WriteLine(i);
                break;
                Console.WriteLine(i);
            }

            i = 0;
            while (true)
            {
                ++i;
                Console.WriteLine(i);
                if (i == 6)
                {
                    break;
                }
            }

            #endregion
            
            //continue : 回到循环开始 继续执行

        //     #endregion
        //
        //     while (true)
        //     {
        //         Console.WriteLine("continue之前的代码");
        //         continue; //continue之后的代码不会再执行了 但是不会跳出 继续循环
        //         Console.WriteLine("continue之后的代码");
        //     }
        //     Console.WriteLine("continue之后的代码");
         
        
        //打印 1-20 之间的 基数
        int index = 0;
        while(index <20)
        {
            ++index;
            if (index % 2 == 0)
            {
                
                continue;
            }
            Console.WriteLine(index);
        }
        //注意 :break 和 continue 主要是和循环配合使用的 和if语句没关
        // break和switch中的作用 和  while循环中的作用有异曲同工之妙


        while(true)
        {
            int a = 1;
            switch (a)
            {
                default: 
                    continue;// 跟while有关
                break; // 与switch有关
            }
            Console.WriteLine(a);
        }
        
        
        }
    }
}