using System;
using System.Numerics;

namespace Lesson12
{
    class Program       
    {
        static void Main(string[] age)  
        {

            #region 1

            

            
            // 用于比较两个变量或常量
            // 是否大于>
            // 是否小于<
            // 是否等于==
            // 是否不等于!=
            // 是否大于等于>=
            // 是否小于等于<=
            // 条件运算符一定存在左右两边的东西
            //     左边内容 条件运算符 右边内容
            int a = 5;
            int b = 10;
            //条件运算符不能直接像这样使用a < b;
            //纯比较不用结果 那么对于我们来说 没有任何意义
            //a > b;
            //比较的结果 返回的是 一个bool类型的值
            //满足条件就返回true 不满足就返回false
            //先算右边 再赋值给左边
            bool result = a > b;
            Console.WriteLine(result);
            bool sb = a < b;
            Console.WriteLine(sb);
            bool cb = a == b;
            Console.WriteLine(cb);
            bool cc = a != b;
            Console.WriteLine(cc);
            bool dd = a >= b;
            Console.WriteLine(dd);
            bool ee = a <= b;
            Console.WriteLine(ee);
            #endregion

            #region 2.各种应用写法

            {
                //变量与变量的比较
                a = 5;
                b = 10;
                result = a > b;
                
                Console.WriteLine(result);
                //变量与常量的比较
                result = a < 10;
                
                //数值与数值的比较
                result = 10 > 11;
                result = 11 != 10;
                
                //计算结果的比较
                //条件运算符的 优先级 低于算数运算符
                result =  10 - 11 < 11 -10 * 2;
                Console.WriteLine(result);
                //先计算 再比较


            }
            

            #endregion
            #region 3.不能进行范围比较

            {
                //判断是否在某两个值之间
                //1 < a <6
                //c#中不能这么写
                //要判断 一个变量是否在两个数之间 要结合 逻辑运算符的知识点
                
            }
                

            #endregion

            #region 4.不同类型之间的比较
            //不同数值类型之间 可以随意进行条件运算符比较
            int i = 5;
            byte by = 4;
            float f = 1.1f;
            uint ui = 1;
            short s = 2;
            ushort us = 3;
            double d = 1.1;
            
            //只要是数值就能进行条件运算符的比较 比较大于小于等于等等

            result = i > f;
            result = i > b;
            result = i > by; 
            result = f > ui;
            result = f > s;
            
            
            //特殊类型 char string bool  

            string str = "sbbb";
            char ch = 'c';
            bool bo = true;

            //result =  ch != bo;  报错！ 只能同类比较 == 和 !=比较 

            result = str != "das";
            result = str == "sbbb";

            result = ch == 'a';
            //char 特殊 当和数字比较是不会报错 因为将当字符转化成ascll码

            result = ch > 5;
            result = ch < 10;

            #endregion

        }
    }
}