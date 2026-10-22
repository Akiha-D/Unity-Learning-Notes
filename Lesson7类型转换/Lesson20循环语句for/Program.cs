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
            //常用
            Console.WriteLine("Lesson 20 循环语句 for");

            #region 1.基本语法

            // for (/*初始表达值*/;/*条件表达式*/;/*增量表达式*/)
            // {
            //     //循环代码逻辑
            // }
            
            //第一个空（初始表达值）一般声明一个临时变量，用来计数用
            //第二个空（条件表达式）表明进入循环的条件 一个bool类型的结果 （bool类型 条件运算符 逻辑运算符 算数运算符）
            //第三个空（增量表达式）用第一个空的变量 进行 自增减运算
            
            //第一次进入循环时 才会调用 第一个空中的代码
            //每次进入循环前 都会判断第二个空的条件 符合条件才会进入逻辑循环
            
            for (int i = 3; i < 10; i++)
            {
                Console.WriteLine(i);
                //执行完循环语句块中的逻辑后
                //最后执行第三个空中的代码
            }

            for (int i = 10; i >=3; i--)
            {
                Console.WriteLine(i);
            }
            #endregion
            //每个空位 可以按照规则进行书写
            //第一个空位 就是申明变量  所以可以连续申明
            //第二个空位 就是进入条件 只要是bool结果的表达式 都可以
            //第三个空位 就是执行一次循环逻辑过后要做的事情 做啥都行
            //for( int i = 0, j = 0; i < 10 && j < 0; ++i, j = j + 1)
            //{

            //}
            #region 2.嵌套使用

            for (int f = 0; f < 5; f++)
            {
                for (int d = 0; d < 6; d++)
                {
                    Console.WriteLine(f + "_" + d );
                }
                //同时while do 等其他也可以嵌套
            }
            #endregion
            
            #region 3特殊写法
            //for循环这三个空可以都空着 可以根据需求去填写
            //平时不要这么写
            
            //for可以写死循环
            // for (;;)
            // {
            //     Console.WriteLine("for的死循环");
            // }
            
            
            int u = 0;
            for (; u < 2; )
            {
                u++;
                Console.WriteLine(u);
            }
            

            #endregion

            #region 4.对比while循环

            //for循环 一般用来可以准确得到 一个范围中的所有数

            for (int i = 3; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int k = 3;
            while ( k < 10)
            {
                k++;
                Console.WriteLine(k);
            }
            
            //for更简洁
            #endregion
        }

    }
}