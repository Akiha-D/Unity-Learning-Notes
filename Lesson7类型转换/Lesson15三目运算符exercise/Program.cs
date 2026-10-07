using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Lesson15exercies
{
    class Program       
    {
        static void Main(string[] age)
        {
            
            //1. 比两个数大小
            try
            {
                Console.WriteLine("pls enter a number1");
                string num1 = Console.ReadLine();
                Console.WriteLine("pls enter a number2 again");
                string num2 = Console.ReadLine();
                
                int numA = int.Parse(num1);
                int numB = int.Parse(num2);
                
                string str0 = numA > numB ? "num1更大": "num2更大";
                Console.WriteLine(str0);
                
            }
            catch 
            {
                Console.WriteLine("请输入数字");
            }
            
            //2.提示用户输入一个姓名，然后再控制台输出姓名，只要输入的不是帅哥，就显示美女。
            
            Console.WriteLine(" 请输入姓名");
            string name = Console.ReadLine();

            string str2 = name == "帅哥" ? "帅哥" : "美女";
            Console.WriteLine(name + str2);

            //3.依次输入学生的姓名，C#语言的成绩，Unity的成绩，两门成绩都大于等于90分，才能毕业，请输出最后的结果
            try
            {
                Console.WriteLine("pls enter u name");
                name = Console.ReadLine();
            
                Console.WriteLine("please enter your csharpScore");
                string csharpScore = Console.ReadLine();
                int i1= Convert.ToInt32(csharpScore);

                Console.WriteLine("please enter your unityScore");
                string unityScore = Console.ReadLine();
                int i2 = Convert.ToInt32(unityScore);
                string str1;
                str1 = i1 >= 90 & i2 >= 90 ? name + " 你达成了毕业要求" : name + " 你未达成毕业要求";
                //! 使用一个 & 是 无论前面的条件是否正确 后面的的内容依旧会计算 而使用 && 两个 则当前面为 false时 右边直接跳过不计算 整体结果必为 false
                Console.WriteLine(str1);
            }
            catch 
            {
                Console.WriteLine("请输入正确的格式");
            }

            
            //4.要求用户输入一个年份，然后判断是不是闰年？闰年判断条件：年份能被400整除（2000)
            //或者 年份能被4整除，但是不能被100整除（2008）

            try
            {
                Console.WriteLine("please enter a year");
                string year = Console.ReadLine();
                int i3 = Convert.ToInt32(year);

                string str1;
                str1 = i3 % 400 == 0 || i3 % 4 ==0 && i3 % 100 !=0 ? "输入的是闰年" : "输入的不是闰年";
                Console.WriteLine(str1);
            }
            catch 
            {
                Console.WriteLine(" 请输入正确格式");
            }


            



        }
    }
}