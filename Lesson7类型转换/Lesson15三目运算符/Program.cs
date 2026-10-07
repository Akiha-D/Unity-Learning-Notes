using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Lesson15
{
    class Program       
    {
        static void Main(string[] age)
        {   
            //三目运算符

            #region 1.基本语法
            //套路 : 三个空位 两个符号
            //固定语法 : 空位     ? 空位        :       空位;
            //关键信息 : bool类型 ? bool类型为真 返回内容 : bool类型为假 返回内容;
            //三目运算符 会有返回值 这个返回值类型必须一致 并且必须使用 !

            #endregion

            #region 2.具体使用

            string str1 = true ? "条件为真" : "条件为假";
            Console.WriteLine(str1);
            
            string str2 = false ? "条件为真" : "条件为假";
            Console.WriteLine(str2);
            
            
            //第一位空位 必须要求 结果是bool类型的 可以用之前的 条件运算符相关的 逻辑表达式等
            //例如

            int a = 5;
            string str3 = a > 2 ? "a 大于 2" : "a不满足条件";
            Console.WriteLine(str3);
            
            //第二,三空位 什么表达式都可以 但是要保证两个类型相同
            //会报错 string str3 = a > 2 ? "a 大于 2" :  1; 返回值类型必须一致！
            
            
            
            #endregion





        }
    }
}