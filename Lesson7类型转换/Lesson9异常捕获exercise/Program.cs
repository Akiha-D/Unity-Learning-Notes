using System;

namespace Lesson9Exercise
{
    class Program       
    {
        static void Main(string[] age)
        {
            
            #region Exercises1
            //Exercies 1 请用户输入一个数字 如果输入有错 则提示用户输入错误
            try
            {
                Console.WriteLine("请输入一个数字");
                string str = Console.ReadLine();
                int num = int.Parse(str);
            }
            catch 
            {
                Console.WriteLine("输入有错");
            }
            #endregion 
            

            
            
            
            //Exercises 2 提示用户输入姓名，语文 ，数学， 英语成绩 如果输入的成绩有误 则提醒用户输入错误 把成绩用整形变量存储

            Console.WriteLine("请输入姓名");
            string str0 = Console.ReadLine();
           
            try
            {
                Console.WriteLine("请输入语文成绩");
                string str1 = Console.ReadLine();
                int num = int.Parse(str1);
                
                //int yuwen = int.Parse(Console.ReadLine());
                //上面两句可以缩减为一句 并且 少声明一个变量
                

            }
            catch 
            {
                Console.WriteLine("输入错误");

            }
            
            try
            {
                Console.WriteLine("请输入数学成绩");
                string str2 = Console.ReadLine();
                int num = int.Parse(str2);

            }
            catch 
            {
                Console.WriteLine("输入错误");

            }
            
            try
            {
                Console.WriteLine("请输入英语成绩");
                string str3 = Console.ReadLine();
                int num = int.Parse(str3);

            }
            catch 
            {
                Console.WriteLine("输入错误");

            }
            


        }
    }
}