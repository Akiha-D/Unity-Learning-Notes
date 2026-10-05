using System;

namespace Program
{
    class Program3
    {
        static void Main(string[] age)
        {
            //有符号
            int sbyteSize = sizeof(sbyte);
            Console.WriteLine("sbyte" + sbyteSize);
            int inteSize = sizeof(int);
            Console.WriteLine("int" + inteSize);
            int shorteSize = sizeof(short);
            Console.WriteLine("short" + shorteSize);
            int longSize = sizeof(long);
            Console.WriteLine("long" + longSize);
            
            
            //无符号
            Console.WriteLine("无符号");
            
            int byteSize = sizeof(byte);
            Console.WriteLine("byte" + byteSize);
            int uinteSize = sizeof(uint);
            Console.WriteLine("uint" + uinteSize);
            int ushorteSize = sizeof(ushort);
            Console.WriteLine("ushort" + ushorteSize);
            int ulongSize = sizeof(ulong);
            Console.WriteLine("ulong" +ulongSize);

            
            //浮点数
            Console.WriteLine("浮点数");
            int floatSize = sizeof(float);
            Console.WriteLine("float" + floatSize);
            int doubleSize = sizeof(double);
            Console.WriteLine("double" + doubleSize);
            int decimalSize = sizeof(decimal);
            Console.WriteLine("decimal" + decimalSize);

            //特殊类型
            Console.WriteLine("特殊类型");
            int boolSize = sizeof(bool);
            Console.WriteLine("bool" + boolSize);
            int charSize = sizeof(char);
            Console.WriteLine("char" + charSize);
            
            //sizeof不能得到string类型所占的大小 因为字符串是不定的可变的
            //int stringlSize = sizeof(string);
            
            //sbyte 1 int 4 short 2 long 8 /byte 1 uint 4 ushort 2 ulong 8 
            //float 4 double 8 decimal 16  /bool 1 char 2 string 
        }
    }
}