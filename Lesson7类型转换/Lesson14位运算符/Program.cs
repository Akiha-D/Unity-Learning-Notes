using System;
using System.Numerics;

namespace Lesson14
{
    class Program       
    {
        static void Main(string[] age)
        {   
            //位运算符  主要用数值类型进行计算的
            //将数值转化为二进制 再进行计算

            #region 1.位与 &
            //规则 连接两个数值进行位运算 将数值转化为二进制
            //对位计算 有0则0

            int a = 1; //001
            int b = 5; //101
            
            
            string bBinary = Convert.ToString(b, 2);
            Console.WriteLine(bBinary);
            //转换为二进制(教程还没讲到 Binary是二进制的意思) 
            
            //a & b 必须要被使用 否则会报错
            
            //对位运算
            //001
            //101
            //从右往左看 有0则0
            //001
            
            Console.WriteLine(a & b);//1

            a = 3; //11
            b = 19; //10011
            

            int c;
            c = a & b;
            
            //00011
            //10011
            
            //00011
            
            bBinary = Convert.ToString(b, 2);
            Console.WriteLine(bBinary);
            
            Console.WriteLine(c);//3

            //多个数值进行运算 没有括号时 从左到右 依次运算

            a = 1; //001
            b = 5; //101
            c = 19;//10011
            
            
            //  00001
            //  00101
            //& 00001
            //  10011
            //& 00001
            bBinary = Convert.ToString(b, 2);
            Console.WriteLine(bBinary);
            
            Console.WriteLine( a & b & c); //1

            #endregion

            #region 2.位或 |
            
            Console.WriteLine( "2.位或 |");

            //规则 连接两个数值进行位运算 将数值转化为二进制
            //对位计算 有1则1


            a = 1;//001
            b = 5;//101
            c = a | b;
            
            
            Console.WriteLine(c); //101 /5

            a = 5;//101
            b = 10;//1010
            c = 20;//10100
            
                    //   00101
                    //   01010
                    // | 01111
                    
                    //   10100
                    // | 11111
            int d;
            d = a | b | c;
            bBinary = Convert.ToString(b, 2);
            Console.WriteLine(bBinary);
            string cBinary = Convert.ToString(c, 2);
            Console.WriteLine(cBinary);
            
            Console.WriteLine(d); //31

            #endregion

            #region 3.异或 ^
            Console.WriteLine( "3.异或 ^");
            //位运算符  主要用数值类型进行计算的
            //对位运算 相同为0 不同为1
            
            a = 1;//001
            b = 5;//101
                //100
            Console.WriteLine( a ^ b ); //4

            a = 10; //1010
            b = 11; //1011
            c = 4;  //100
            
                    // 0001
                    // 0100
                    //^0101
            Console.WriteLine( a ^ b ^ c ); //5
            
            #endregion

            #region 4.位取反 ~
            Console.WriteLine( "4.位取反");
            //规则 写在数值前面 将数值转为2进制
            //对位运算 0变1 1变0
            
            a = 5; //101
            b = ~a;
            
            // a 是 int 类型 4字节 // 1 字节 = 8 位
            // 0000 0000 0000 0000 0000 0000 0101
            // 1111 1111 1111 1111 1111 1111 1010
            // 最开头的是代表符号 所以变成1 输出为负数
            //反码补码的知识
            Console.WriteLine(b); 

            #endregion
    

            #region 5.左移 << 和 右移 >>
            //规则 让一个数的二进制数进行左移或右移
            //左移几位 右侧加几个0

            Console.WriteLine("5.");
            a = 5; //101
            c = a << 1;
            //左移一位 1010
            //左移两位 10100
            //接下来同理
            
            Console.WriteLine(c); //10 /二进制1010
            
            cBinary = Convert.ToString(c, 2);
            Console.WriteLine(cBinary);
            
            // 右移几位 右侧去掉几个数

            a = 5; //101
            c = a >> 1; //右移一位  10
            Console.WriteLine(c); //2
            c = a >> 2; //右移两位 1
            Console.WriteLine(c); //1

            #endregion


        }
    }
}