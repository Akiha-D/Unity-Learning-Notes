using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Lesson17exercise
{
    class Program       
    {
        static void Main(string[] age)
        {   
            Console.WriteLine("条件分支语句_switch exercise");

            #region 1
            Console.WriteLine("请输入你的评级");
            
            string str = Console.ReadLine();

            int money = 4000;

            switch (str)
            {
                case "A":
                    Console.WriteLine(money + 500);
                    break;
                case "B":
                    Console.WriteLine(money );
                    break;
                case "C":
                    Console.WriteLine(money - 300);
                    break;
                case "D":
                    Console.WriteLine(money - 500);
                    break;
                case "E":
                    Console.WriteLine(money - 800);
                    break;
                    
                default:
                    Console.WriteLine(" 请输入正确的评级");
                    break;
            }

            #endregion

            #region 2.
            money = 10;
            Console.WriteLine("选择什么型号 (1是中杯 2是大杯 3是超大杯)");
            
            string str2 = Console.ReadLine();
            switch (str2)
            {
                case "1":
                    money -= 5;
                    Console.WriteLine("购买成功，剩余{0}",money);
                    break;
                case "2":
                    money -= 7;
                    Console.WriteLine("购买成功，剩余{0}",money);
                    break;
                    
                case "3":
                    money -= 10;
                    Console.WriteLine("钱不够，请更换其他型号");
                    break;
            }
            #endregion
            
            #region 3.
            Console.WriteLine("请输入你的成绩");
            string str3 = Console.ReadLine();
            int i = int.Parse(str3);
            i /= 10;
            switch (i)
            {
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("E");
                    break;
            }
            
            
            #endregion
            
            #region 4.
            Console.WriteLine("请输入0~9中的一个数");
            string str4 = Console.ReadLine();
            int i1 = int.Parse(str4);
            switch (i1)
            {
                case 0:
                    Console.WriteLine("零");
                    break;
                case 1:
                    Console.WriteLine("一");
                    break;
                case 2:
                    Console.WriteLine("二");
                    break;
                case 3:
                    Console.WriteLine("三");
                    break;
                case 4:
                    Console.WriteLine("四");
                    break;
                case 5:
                    Console.WriteLine("五");
                    break;
                case 6:
                    Console.WriteLine("六");
                    break;
                case 7:
                    Console.WriteLine("七");
                    break;
                case 8:
                    Console.WriteLine("八");
                    break;
                case 9:
                    Console.WriteLine("九");
                    break;
                default:
                    Console.WriteLine("请输入正确的格式");
                    break;
            }
            
            
            #endregion
        }
    }
}