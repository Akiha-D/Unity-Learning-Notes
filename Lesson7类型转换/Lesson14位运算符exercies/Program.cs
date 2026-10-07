using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Lesson14exercies
{
    class Program       
    {
        static void Main(string[] age)
        {   
        //1. 33<<4  和 66 > 1 的结果为？
        int a = 33; //100001
        
        String aBinary = Convert.ToString(a, 2);
        Console.WriteLine(aBinary);
        int b;
        b = a << 4;
        //10001
        //1000010000
        Console.WriteLine(b);

        int c = 528;
        String cBinary = Convert.ToString(c, 2);
        Console.WriteLine(cBinary);

        a = 66; //1000010
        b = a >> 1; //100001
        
        aBinary = Convert.ToString(a, 2);
        Console.WriteLine(aBinary);
        Console.WriteLine(b); //33
        
        String bBinary = Convert.ToString(b, 2);
        Console.WriteLine(bBinary); //100001

        }
    }
}