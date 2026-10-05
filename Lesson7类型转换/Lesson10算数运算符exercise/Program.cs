using System;

namespace Lesson10exercise
{
    class Program       
    {
        static void Main(string[] age)
        {
            // Console.WriteLine("请输入你的Age");
            // int age1 =Convert.ToInt32(Console.ReadLine()) + 10;
            // Console.WriteLine("十年后你是"+age1);

            int age1 = 18;
            age1 += 10;
            Console.WriteLine("十年后是" + age1);


            float f = 5;
            Console.WriteLine(f);
            float r = 5f;
            float PI = 3.1415f;
            float S;
            S = r *= r * PI;
            Console.WriteLine(S);

             r = 5f;
            float zhouChang;
            zhouChang = 2 * PI * r;
            Console.WriteLine(zhouChang);
            
            //3
            int c1 = 80;
            int c2 = 100;
            int c3 = 90;
            float avg;
            avg = (c1 + c2 + c3) / 3;
            Console.WriteLine(avg);
            
            //4
            int tshirt = 285;
            int trousers = 720;
            float pay;
            pay = tshirt * 2 + trousers * 3;
            Console.WriteLine(pay);
            pay *= 0.38f;
            Console.WriteLine(pay); 
            
            //5


            int a = 10;
            int b = 20;
            int number1 = ++a + b;
            Console.WriteLine(number1);
            a = 10;
            b = 20;
            int number2 = a + b++;
            Console.WriteLine(number2);
            a = 10;
            b = 20;
            int number3 = a++ + ++b + a++;
                //注意！这里从左到右 最后一个 a++ 的a 已经是11因为开头那个 是先用后加
            Console.WriteLine(number3);
            //10 + 21 +11
            //42
                a = 10;
                b = 20;
            int number4 = a++ + ++b + ++a;
            //10 +21 +12
            //43
            Console.WriteLine(number4);
            
            //5.
            a = 99;
            b = 87;
            a += b - a;
            Console.WriteLine(a);
            a = 99;
            b = 87;
            b += a - b;
            Console.WriteLine(b);

            a = 99;
            b = 87;
            a = b ;
            Console.WriteLine(a);
            a = 99;
            b = 87;
            b = a;
            Console.WriteLine(b);
            
            a = 99;
            b = 87;
            int temp = a;
            
            
            
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            //6.
            //请把987652秒通过代码转化为n天n小时n分钟n秒显示到控制台中
            int t7 = 987652;
            
            int oneDayS = 60 * 60 * 24;
            
            int oneHours = 60 * 60;
            
            int oneMinutes = 60 ;
            
            int hours = t7 % oneDayS / oneHours;
            
            int minutes = t7 % oneDayS % oneHours/ oneMinutes;
            
            int s = t7 % oneDayS % oneHours % oneMinutes  ;
            
            //可以替代为 int s = t7 %60
            
            Console.WriteLine( t7 / oneDayS + "天" + hours + "小时" + minutes + "分钟" + s + "秒");
            





        }
    }
}