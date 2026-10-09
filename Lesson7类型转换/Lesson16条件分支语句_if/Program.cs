using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Lesson16
{
    class Program       
    {
        static void Main(string[] age)
        {   
            Console.WriteLine("条件分支语句_if");

            #region 1.作用
            //让顺序执行的代码啊 产生分支    
            //if语句是第一个可以让我们的程序 产生逻辑变化的 语句
            
            #endregion

            #region 2.if语句 
            //作用 : 满足条件时 多执行一些代码
            //语法
            //if ( bool 类型值) //bool类型相关 : bool变量 条件运算符表达式 逻辑运算符表达式等
            //{
            //  满足条件要执行的代码 写在if代码块中
            //}
            
            //注意
            //if语句的语法部分,不需要写分号;
            //if语句可以嵌套使用


            int a = 5;
            if (a > 3) //true
            {
                Console.WriteLine("ture");
            }

            if (a < 3) //false
            {
                Console.WriteLine("false");
            }
            Console.WriteLine("if以外的");
            

            //嵌套使用
            if (a > 2)
            {
                Console.WriteLine("a > 2");
                if (a > 4)
                {
                    Console.WriteLine("a > 4");
                    //可以无限嵌套
                }
            }
            
            #endregion

            #region 3.if...else语句
            //作用: 产生两条分支 满足条件做什么 不满足条件做什么
            
            //语法：
            // if (bool 类型值)
            //{
            //      满足条件要执行的代码 
            //}
            //else
            //{
            //      不满足条件要执行的代码 
            //}

            //注意 和if相同
            
             if (true)
            {
                Console.WriteLine("满足条件要执行的代码"); 
            }
            else
            {
                Console.WriteLine("不满足条件要执行的代码");
            }

             //嵌套 //if else 里都能嵌套
             if (true)
             {
                 Console.WriteLine("满足条件要执行的代码"); 
                 if (true)
                 {
                     Console.WriteLine("满足条件要执行的代码"); 
                 }
                 else
                 {
                     Console.WriteLine("不满足条件要执行的代码");
                 }
             }
             else
             {
                 Console.WriteLine("不满足条件要执行的代码");
                 if (true)
                 {
                     Console.WriteLine("满足条件要执行的代码"); 
                 }
                 else
                 {
                     Console.WriteLine("不满足条件要执行的代码");
                 }
             }
            #endregion

            #region 4.if ..... else if ......else语句
            //产生多条分支 多条道路选择 最先满足其中的一个条件 就做什么
            
            // if (bool 类型值)
            //{
            //      满足条件要执行的代码 
            //}
            //else if (bool 类型值)
            //{
            //      满足条件要执行的代码 
            //}
            //else
            //{
            //      不满足条件要执行的代码 
            //}
            
            //注意 与之前相同
            //else if 中的 else可以省略 但是如果全是if 则都会判断一边
            //注意 条件判断 从上到下执行 满足了第一个后 后面的就不会再执行了

            a = 8;
            if (a > 3)
            {
                Console.WriteLine("a > 3");
                
                
            }
            else if  (a == 3)

            {
                Console.WriteLine("a = 3");
            }

            else 
            {
                Console.WriteLine("a < 3");
            }

            //else if效率更高 当执行到else if  (a == 3) 如果条件满足将不会往下进行 
            #endregion



        }
    }
}