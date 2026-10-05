using System;

namespace Lesson9
{
    class Program       
    {
        static void Main(string[] age)
        {
            
            
            //string str0 = Console.ReadLine();
            //将玩家输入的内容 存储string的类型（容器）中
            //int i = int.Parse(str0);
            //Parse转字符串为 数值类型是 必须要合法合规
            // Console.WriteLine(i);
            // Console.ReadKey();

            try
            {
                string str0 = Console.ReadLine();
                int i = int.Parse(str0);
                Console.WriteLine(i);
            }
            catch
            {
                Console.WriteLine("请输入合法数字");

            }
            finally
            {
                Console.WriteLine("执行完毕");
            }

            //基本语法
            //必备部分

            #region MyRegion

            

            
            try
            {
                //希望进行异常捕获的代码块
                //放到try中
                //如果try中的代码 报错了 不会让程序卡死
                
            }
            catch
            {
                //如果出错了 或执行catch里的代码 来捕获异常
                //catch(Exception e) 具体报错跟踪 通过e得到 具体的报错信息
            }

            //可选部分
            finally
            {
                //最后执行的代码 不管有没有出错 都会执行里面的代码
                //目前可以不用写
            }
            
            //注意：异常捕获代码结构中 不需要去加;　在里面写代码逻辑时 每一句结束后才加   
            #endregion
            
            
        }
    }
}