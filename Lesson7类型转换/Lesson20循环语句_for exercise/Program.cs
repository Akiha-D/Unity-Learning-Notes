using System;

namespace Lesson20_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for循环练习题");
            #region 练习题一
            //输出1到100之间的整数（包含本身）
            for (int i = 1; i < 101 ; i++)
            {
                Console.WriteLine(i);
            }
            
            #endregion

            #region 练习题二
            //求1~100之间所有偶数的和
            int sum = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }

                //或者for后改成 i+=2
            }
            Console.WriteLine(sum);
            #endregion

            #region 练习题三
            //找出100~999之间的水仙花数
            //例如：153 = 1 * 1 * 1 + 5 * 5 * 5 + 3 * 3 * 3 这个数就是水仙花数
            for (int i = 100;i <=999 ; i++)
            {
                int a = i / 100;
                int b = (i - a * 100) / 10;
                int c = (i - a * 100) - b * 10;
                if (i == a * a * a + b * b * b + c * c * c)
                {
                    Console.WriteLine(i);
                }
            }
            
            
            #endregion

            #region 练习题四
            //在控制台上输出九九乘法表
            for (int i = 1; i < 10; i++) 
            {
                for (int a = 1; a < 10; a++)
                {
                    int b = a * i;
                    Console.Write("{0} * {1} = {2}" , i, a, b);
                    Console.WriteLine("");
                    }
            }

            #endregion

            #region 练习题五

            //在控制台上输出如下10 * 10的空心星型方阵
            //**********
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //**********

            //}
            for (int i = 1; i < 11; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine("**********");
                    
                }
                else if (i == 1)
                {
                    Console.WriteLine("**********");
                }
                else
                {
                    Console.WriteLine("*        *");
                }


            }


            #endregion

            #region 练习题六

            //在控制台上输出如下10 * 10的三角形方阵
            //*       1   1
            //**      2   2
            //***     3   3
            //****    4   4
            //*****
            //******
            //*******
            //********
            //*********
            //**********

            for (int i = 1; i < 11; i++)
            {
                for (int r = 1; r <=i; r++)
                {
                    
                        Console.Write("*");
                    
                    
                    
                }
                Console.WriteLine();
            }
            #endregion

            #region 练习题七

            //在控制台上输出如下10行的三角形方阵
            //         *            1    1   -> 2i - 1    9    10 - i
            //        ***           2    3   -> 2i - 1    8    10 - i
            //       *****          3    5                7    10 - i
            //      *******         4    7                6    10 - i
            //     *********        5    9                5
            //    ***********       6    11               4
            //   *************      7    13               3
            //  ***************     8    15               2
            // *****************    9    17               1
            //*******************   10   19               0    10 - i
            //行
           
           
           
           
            
            for (int i =  1; i < 11; i++)
            {
                for (int f = 1; f <= 10- i; f++)   
                {                                 
                    Console.Write(" ");           
                }                                 
                int b = i * 2;
                for (int a = 1; a <= b-1; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            #endregion

        }
    }
}
