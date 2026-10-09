using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Lesson16exercies
{
    class Program       
    {
        static void Main(string[] age)
        {   
            Console.WriteLine("条件分支语句_if exercise");

            #region 1.
            //请用户输入今日看唐老狮视频花了多少分钟，如果大于60分钟，那么在
            //控制台输出“今天看视频花了XX分钟，看来你离成功又进了一步！”
            
            Console.WriteLine("请输入今日看唐老狮视频花了多少分钟");

            try
            {
                string min = Console.ReadLine();
                int min1 = int.Parse(min);

                if (min1 > 60)
                {
                    Console.WriteLine("今天看视频花了" + min1 + "分钟，看来你离成功又进了一步！");
                }

                else
                {
                    Console.WriteLine(" 需要继续努力");
                }

            }

            catch
            {
                Console.WriteLine("请输入正确的格式");
            }

            #endregion
            
            #region 2.
            // 请输入你的语文，数学，英语成绩，满足以下任意条件，则输出"非常棒，继续加油”
            // 语文成绩大于70并且数学成绩大于80并且英语成绩大于90
            // 语文成绩等于100或者数学成绩等于100或者英语成绩等于100
            // 语文成绩大于90并且其它两门中有一门成绩大于70

            try
            {
                Console.WriteLine("请输入你的语文成绩");
                int yuWen = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入你的数学成绩");
                int shuXue = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入你的英语成绩");
                int english = int.Parse(Console.ReadLine());

                if (yuWen > 70 && shuXue > 80 && english > 9)
                {
                    Console.WriteLine("非常棒，继续加油");
                }
                
                else if (yuWen == 100 || shuXue == 100 || english == 100)
                {
                    Console.WriteLine("非常棒，继续加油");
                }
                else if (yuWen >90 && shuXue >70 || english >70)
                {
                    Console.WriteLine("非常棒，继续加油");
                }
                else
                {
                    Console.WriteLine("继续加油");
                }
                    
                    
                    
            }
            catch 
            {
                Console.WriteLine("请输入正确的格式");
            }

            
            
            #endregion
            
            #region 3.
            // 定义一个变量，存储小赵的考试成绩，如果小赵的考试成绩大于（含）
            // 90分，那么爸爸奖励100元钱，否则一个月不能玩游戏
            try
            {
                Console.WriteLine("pls enter 小赵的考试成绩");
                int num1 = int.Parse(Console.ReadLine());

                if (num1 >= 90)
                {
                    Console.WriteLine("you get 100RMB");
                }
                else
                {
                    Console.WriteLine("you pc ban 30days");
                }

            }
            catch 
            {
                Console.WriteLine("请输入正确的格式");
            }

            #endregion
            
            #region 4.            
            //要求用户输入两个数a、b，如果两个数可以整除或者这两个数加起来大于100，
            //则输出a的值，否则输出b的值
            // 控制台输入 类型转换  异常捕获  算数运算符  条件运算符  逻辑运算符

            try
            {
                Console.WriteLine("pls enter num1");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("pls enter num2");
                int b = int.Parse(Console.ReadLine());

                bool a1 = a % b == 0 || b % a ==0;
                bool b1 = a + b >100;

                if (a1 ||b1)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
            catch 
            {
                Console.WriteLine("请输入正确的格式");
            }
            #endregion
            
            
            #region 5.
            //输入一个整数，如果这个数是偶数，则打印“Your input is even”，否则打印“Your input is odd”
            try
            {
                Console.WriteLine("pls enter a 整数");
                int a = int.Parse(Console.ReadLine());
                bool a1 = a % 2 == 0;
                
                if  (a1)
                {
                    Console.WriteLine("Your input is even");
                }
                
                else
                {
                    Console.WriteLine("Your input is odd");
                }

            }
            catch 
            {
                Console.WriteLine("请输入正确的格式");
            }
            
            
            #endregion
            
            #region 6.
            //有3个整形变量，分别存储不同的值，编写代码输出其中最大的整数
            try
            {
                Console.WriteLine("pls enter a 整数");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("pls enter a 整数");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("pls enter a 整数");
                int c = int.Parse(Console.ReadLine());

                bool a1 = a > b && a > c;
                bool b1 = b > c && b > a;
                //bool c1 = c > a && c > b;
                
                if  (a1)
                {
                    Console.WriteLine(a);
                }
                
                else if (b1)
                {
                    Console.WriteLine(b);
                }
                
                // else if (c1)
                //
                // {
                //     Console.WriteLine(c);
                // }
                
                else
                {
                    Console.WriteLine(c);
                }

            }
            catch 
            {
                Console.WriteLine("请输入正确的格式");
            }
            
            
            #endregion
            
            #region 7.
            //写一个程序接受用户输入的字符，如果输入的字符是0~9数字中的一个，
            //则显示“您输入了一个数字”，否则显示这不是一个数字
       
            
               

                try
                {
                    Console.WriteLine("请输入字符");
                    char c = Console.ReadKey().KeyChar; //通过ReadKey().KeyChar得到输入的一个字符
                    int num = int.Parse(c.ToString());//Parse只能转字符串 所以要 先将char 转 String 再转成int
                    
                    //!!通过Convert 把Char 转成整形 转过去的是对应的ASKII码 的数值
                    //int num1 = Convert.ToInt32(c); 
                    
                    bool a1 = num >= 0 && num <= 9  ;
                    
                    
                    if (a1)
                    {
                        Console.WriteLine("您输入了一个数字");
                    }


                }
                catch 
                {
                    Console.WriteLine("这不是一个数字");
                }
                
                // //做法2 通过ASKII码来
                // Console.WriteLine("请输入字符");
                // int num2A = Console.ReadKey().KeyChar; //char隐式转换为int
                // int zeroA = '0';
                // Console.WriteLine(zeroA); //48
                // int nineA = '9';
                // Console.WriteLine(nineA); //57
                // //发现ASKII码 0 - 9 之间是连接的
                // //48 -57
                //
                // if (num2A >= zeroA && num2A <= nineA)
                // {
                //     Console.WriteLine("您输入了一个数字");
                // }
                // else
                // {
                //     Console.WriteLine("这不是一个数字");
                // }





                #endregion
                
                
                #region 8
                //提示用户输入用户名，然后再提示输入密码，如果用户名是“admin”，
                //并且密码是"8888"，则提示正确，否则，
                //如果用户名不是admin还提示用户用户名不存在，如果用户名是admin则提示密码错误
                
                try
                {
                    Console.WriteLine("请输入用户名");
                    string name = Console.ReadLine();
                    Console.WriteLine("请输入密码");
                    string password = Console.ReadLine();


                    
                    if (name == "admin" && password == "8888")
                    {
                        Console.WriteLine("登入成功");
                    }
                    else if (name == "admin" && password != "8888")
                    {
                        Console.WriteLine("密码错误");
                    }
                    else if  (name != "admin" )
                    {
                        Console.WriteLine("用户名不存在");
                    }
                    

                }
                catch 
                {
                    Console.WriteLine("请输入正确的格式");
                }
                
                

                #endregion
                
                #region 9
                //提示用户输入年龄，如果大于等于18，则告知用户可以查看，
                //如果小于13岁，则告知不允许查看，如果大于等于13并且小于18，
                //则提示用户是否继续查看（yes、no），
                //如果输入的是yes则提示用户请查看，否则提示“退出”。
                
                try
                {
                    Console.WriteLine(" pls enter you age");
                    int age1= int.Parse(Console.ReadLine());

                    if (age1 >= 18)
                    {
                        Console.WriteLine("可以查看");
                    }
                    else if (age1 < 13)
                    {
                        Console.WriteLine("不可以查看");
                    }
                    else if (age1 >= 13 && age1 < 18)
                    {
                        Console.WriteLine("是否要查看（yes、no）");
                        string str1 = Console.ReadLine();
                        if (str1 == "yes")
                        {
                            Console.WriteLine("请查看");
                        }
                        else if (str1 == "no")
                        {
                            Console.WriteLine("已退出");
                        }
                        else
                        {
                            Console.WriteLine("请输入规定内容");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("请输入正确内容");
                }


                #endregion
                
                #region 10
                //请说明以下代码的打印结果（不要打一遍代码，请直接通过阅读说出结果）
                int a11 = 5;
                if (a11 > 3)
                {
                    int b = 0;
                    ++b;
                    b += a11; //b = b + a11
                    Console.WriteLine(b); //6
                }
                //!!Console.WriteLine(b); 写在语句块外面会报错
                // 语句块 会影响 变量的 生命周期
                //！！！在语句块里 声明的变量 出了语句块会报错
                //语句块声明 不能有和外面同名的变量
                //函数语句块 目前我们学习知识时  是层级最高的语句块

                #endregion



        }
    }
}