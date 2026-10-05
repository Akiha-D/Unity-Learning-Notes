using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] age)
        {
            #region 字符串拼接方式1


            

            
            string str = "1";

            str = str + "23";


            
            Console.WriteLine(str);
            
            //复合运算符 
            str = "123";
            str += "456" + 78 + true +false ;
            Console.WriteLine(str);
            
            str = "123";
            str += 1 + 2 + 3 + 4;
            //12310
            Console.WriteLine(str);
            
            str = "123";
            str += "" + 1 + 2 + 3 + 4;
            //1231234
            
            str = "";
            str += 1 + 2 +""+ 3 + 4;
            //334

            Console.WriteLine(str);
            
            //注意 用+号拼接 是用符号的唯一方法 不能用- * ++ / 等
            
            #endregion
    
            #region 字符串拼接方式2

            string str2 =string.Format("我是{0},我今年{1}岁,我要{2}","d",19,"天天向上");
            
            string str3 =string.Format("我是{0},我今年{1}岁","d",19);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
        
            

            #endregion

            #region 控制台拼接打印

            Console.WriteLine("我是{0},我今年{1}岁,我要{2}","d",19,"天天向上"); 
            //WriteLine默认提供了和string.Format类似的方法
            //后面的内容 比占位符多 不会报错
            //后面的内容 比占位符少 会报错
            #endregion
        }
    }
}