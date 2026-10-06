using System;
using System.Numerics;

namespace Lesson13
{
    class Program       
    {
        static void Main(string[] age)
        {
            #region 1.逻辑与

            

            
            // 1.逻辑与
            // 符号 &&
            //对两个bool值进行逻辑运算 有假则假 同真则真
            bool result;
            result = false && true;
            Console.WriteLine(result);
            
            result = true && false;
            Console.WriteLine(result);

            result = false && false; //相同但是有fales 所以还是输出Flase
            Console.WriteLine(result);
            
            result = true && true;
            Console.WriteLine(result);
            
            //bool 相关类型 bool变量 条件运算符
            //逻辑运算符优先级 低于 条件运算符 算数运算

            result = (3 - 1) >1 && (2 - 1) >0;
            Console.WriteLine(result);

            int i = 3;
            
            result = i >1 && i  < 5;
            Console.WriteLine(result);
            
            //多个逻辑与组合运用

            int i2 = 5;
            
            result = i >1 && i2 > 3 && i <4;
            Console.WriteLine(result);

            #endregion

            #region 2.逻辑或 
            
            
            // 符号 || 或者
            // 规则 对两个bool值进行逻辑运算 有真则真 同假则假
            
            result = false || true; 
            Console.WriteLine(result);
            
            result = false || false;
            Console.WriteLine(result);
            
            result = true || true;
            Console.WriteLine(result);
            
            result = true || false;
            Console.WriteLine(result);
            
            result = i >1 ||i2 > 3 || i <4;
            Console.WriteLine(result);
            
            result = (3 - 1) <1 || (2 - 1) < 0;
            Console.WriteLine(result);
            #endregion

            #region 3.逻辑非
            //符号  !
            //规则 对一个bool值进行取反 真变假 假变真

            result = !false ;
            Console.WriteLine(result);
            
            result = !true;
            Console.WriteLine(result);


            Console.WriteLine(result);
            
            
            //逻辑非的 优先级较高
            //result = !3 > 2; 报错
            result = !(3 > 2);
            Console.WriteLine(result);

            #endregion

            #region 4.混合使用的优先级问题
            //规则 !逻辑非 优先级最高  &&逻辑与 优先级 高于 ||逻辑或
            //逻辑运算符优先级 低于 算数运算符 条件运算符 ( !逻辑非 除外)
            
            bool gameOver = false;
            int hp = 100;
            bool isDead = false;
            bool isMustOver =  true;
            
            
            // false || false && false || true
            //&&逻辑与 优先级 高于 ||逻辑或
            //true
            result = gameOver || hp < 0  && isDead || isMustOver;
            Console.WriteLine(result);
            
            #endregion

            #region  5.逻辑运算符短路规则

            int i3 = 3;
            //只要 逻辑与 或 逻辑或 左边满足了条件
            //i3>0 true
            //只要满足条件 右边的内容 对我们来说 已经不重要了
            result = i3 > 0 || ++i3 >=1; // ||有真则真
            
            //逻辑或|| 有真则真 只要左边是真的 右边就不重要了
            Console.WriteLine(i3);
            Console.WriteLine(result);
            
            result = i3 < 0 && ++i3 >=1; // && 有假则假
            // flase && ++i3 >=1; 后面被抛弃
            //逻辑与&& 有假则假 只要左边是假的 右边就不重要了
            
            Console.WriteLine(i3);
            Console.WriteLine(result);
            
            #endregion

        }
    }
}