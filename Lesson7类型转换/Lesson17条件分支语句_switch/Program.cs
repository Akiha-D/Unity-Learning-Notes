using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Lesson17
{
    class Program       
    {
        static void Main(string[] age)
        {   
            Console.WriteLine("条件分支语句_switch");

            #region 1.作用
            //让顺序执行的代码啊 产生分支  
            #endregion

            #region 2.基本语法

            // switch ( 变量)
            // {
            //     变量 == 常量 执行case 和 break之间的代码
            //     case 常量:
            //     满足条件执行的代码逻辑
            //     break;
            //         
            //     case 常量:
            //     满足条件执行的代码逻辑
            //     break;
            //     default :
            //     如果上面的case的条件都不满足 就会执行 default中的代码
            //     break;
            //        
            // }

            float f = 1.3f;
            switch (f)
            {
                case 1.1f:
                    Console.WriteLine("1.1f");
                    break;
                case 1.2f:
                    Console.WriteLine("1.2f");
                    break;
                case 1.3f:
                    Console.WriteLine("1.3f");
                    break;
                default:
                    Console.WriteLine("上面条件都不满足 执行default里的");
                    break;
                    
            }


            

            #endregion

            #region 3.default可省去

            string str = "123";
            switch (str)
            {
                case "123": 
                    
                    break;
                case "456": 
                    break;
            }
            

            #endregion

            #region 4.可自定义常量

            char ch = 'b';
            const char a1 = 'a'; // 常量 必须初始化 不能修改
            switch (ch)
            {
                case a1:
                    Console.WriteLine("ch == a");
                    break;
                case 'b':
                    break;
            }

            #region 5.贯穿
            //作用 : 满足某些条件时 做的事情时一样的 就可以使用贯穿

            int c = 5;
            switch (c)
            {
                //不写case后面配对连接的break 就叫做贯穿
                //
            
                case 5: // 不写break
                case 2:

                    Console.WriteLine("是个数字");
                    break;
                    if (c==5)
                    {
                        Console.WriteLine("c=5");
                    }
                    
                    
            }

            #endregion
            
            #endregion
        }
    }
}