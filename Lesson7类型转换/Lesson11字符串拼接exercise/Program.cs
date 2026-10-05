using System;

namespace Lesson10exercise
{
    class Program       
    {
        static void Main(string[] age)  
        {
            #region 1
            //1.定义一个变量存储客户的姓名，然后再屏幕上显示:"你好,xxx"
            Console.WriteLine("pls input you name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " +  name);
            
            //Console.WriteLine("hello,{0} ", name );
            //string str = string.Format("hello,{0} ", name )
                
            
            Console.ReadLine();
            

            #endregion
            
            #region 2

            {
                //定义两个变量 一个存储的姓名 另一个储存变量
                //然后再屏幕上显示:"xxx + yyy岁了"
                Console.WriteLine("pls input you name");
                string name1 =  Console.ReadLine();
                Console.WriteLine("what is you age?");
                int age1 = int.Parse(Console.ReadLine());
                //Console.WriteLine( name1 + age1+ "岁了");
                Console.WriteLine(string.Format("hello {0},you are {1} " ,  name1 , age1));
                //Console.WriteLine("{0}{1}",name1,age1);
            }
            
            #endregion
            
            #region 3

            {
                //当我们去面试时 前台会要求我们填一张表格
                //有姓名 年龄 邮箱 家庭住址 期望工资
                //请把这些信息在控制台输入。
                
                Console.WriteLine("pls input you name");
                string name3 = Console.ReadLine();
                Console.WriteLine("what is you age?");
                int age3 = int.Parse(Console.ReadLine());
                Console.WriteLine("pls input you email");
                string email = Console.ReadLine();
                Console.WriteLine("pls input you address");
                string address = Console.ReadLine();
                Console.WriteLine("pls input you money");
                long money = long.Parse(Console.ReadLine());

                Console.WriteLine("name{0}, age{1},email{2} ,address{3},money{4},", name3,age3,email,address,money );
            }
            #endregion
        }
    }
}