using System;

namespace Lesson10
{
    class Program       
    {
        static void Main(string[] age)
        {
            // 算数运算符
            //     算数运算符 是用于 数值类型变量计算的运算符
            // 它返回的结果可能是数值
            // 1.赋值符号 "="
            //先看右侧再看左侧，把右侧的值赋值给左侧的变量
            
            int c1 = 0;
            
            //2.算数运算符

            #region 加 +

            

            
            //加 +
            //用自己计算 先算右侧结果 ，再赋值给左侧变量
            
            int i = 1;

            i = (1 + i);
            Console.WriteLine(i);
            
            //连续运算
            //右侧所有的算完再给左侧赋值 i之前=2
            i = (1 + 5 + 8 + 11 +  i + i);
            Console.WriteLine(i);
            
            //初始值时就运算 先算右侧结果 ，再赋值给左侧变量
            int i3 = 1 + 2 + 50;
            Console.WriteLine(i3);
            #endregion

            #region 减 -
            
            int i2 = 1;
            i2 = (2 - i2);
            Console.WriteLine(i2);
            //与加同理 先算右侧结果 ，再赋值给左侧变量
            //连续运算 初始值时就运算

            int j1 = 5 - 1;
            

            #endregion

            #region 乘 *

            int i5 = 5;
            i5 = (i5 * 5);
            Console.WriteLine(i5);
            
            i5 = (i5 * i5);
            Console.WriteLine(i5);
            
            //同理 先算右侧结果 ，再赋值给左侧变量
            //连续运算 初始值时就运算


            #endregion

            #region 除 /

            int i6 = 25 / 5;
            Console.WriteLine(i6);
            int i7 = 35 / 5 / 7;
            i6 = 1 / 5; //不会四舍五入
            float f = 1 / 2;//还是会丢失 因为没有加f以为是int类型 默认的整数是int
            Console.WriteLine(f);
            f = 1 / 2f; //必须在其中一个加f 表示为float类型 才不会丢失
            Console.WriteLine(f);

            #endregion

            #region 取余 %
            
            int i8 = 7 % 2 ;
            Console.WriteLine(i8);
            //7 /2 3...1 余1
            int i9 = 8 % 2;
            Console.WriteLine(i9);

            int i10 = 9 % 2 % 2;
            Console.WriteLine(i10);



            #endregion

            #region 算数运算符的优先级

            

            
            //3.算数运算符的优先级
            // 优先级是指在混合运算时的运算顺序
            
            // 乘除取余 优先级高于 加减 先算乘除取余  后算加减
            
            // 括号可以改变优先级 优先计算括号内的内容
            
            // 多组括号 先计算最里层的括号 依次往外算


            int i11 = (30 % (15 + 11) )* 2 + 1;
            Console.WriteLine(i11);
            #endregion

            #region 算数运算符 的符合运算符
            //4.算数运算符 的符合运算符
            

            
            
            int i12 = 6;

            i12 += 10; // i12 +10
            Console.WriteLine(i12);
            i12 -= 1;
            Console.WriteLine(i12);

            int i13 = 6;
            i13 += 20 *2 / 5; 
            Console.WriteLine(i13);

            int i14 = 2;
            i14 += 2; //4
            
            i14 -= 2; //2
            Console.WriteLine(i14);
            i14 *= 2; //4
            Console.WriteLine(i14);
            i14 /= 2; //2
            Console.WriteLine(i14);
            i14 %= 2; //0   
            Console.WriteLine(i14);
            
            #endregion
            
            #region 算数运算符的 自增减
            //5.算数运算符的 自增减
            int a1 = 1;
            a1 += 1; //a1 = a1+ 1 
            Console.WriteLine(a1);
            
            //自增运算符 让自己加1
            a1 = 1;
            a1++; //先用再加
            Console.WriteLine(a1);
            
            ++a1; //先加再用
            Console.WriteLine(a1);


            a1 = 1;
            Console.WriteLine(a1++);
            //先用再加 这个时候输出为1
            //现在a1 =2
            Console.WriteLine(++a1);
            //先加再用 输出为3 2+1
            
            
            //自减运算符 让自己减1
            
            a1 = 1;
            a1--;//先用再减

            --a1;//先加再减
            
            a1 = 1;
            Console.WriteLine(a1--);
            //先用再减 这个时候输出为1
            //现在a1 =0
            Console.WriteLine(--a1);
            //先减再用 这个时候输出为-1
            #endregion


        }
    }
}