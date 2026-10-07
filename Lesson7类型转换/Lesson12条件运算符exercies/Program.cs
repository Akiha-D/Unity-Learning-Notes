using System;
using System.Numerics;

namespace Lesson12exercies
{
    class Program       
    {
        static void Main(string[] age)
        {
            bool b = true;
            Console.WriteLine(b != true);
            Console.WriteLine(10 == 10);
            Console.WriteLine(10 <= 20);
            Console.WriteLine(10 >= 20);


            bool gameover,startGame;
            int a = 10;
            int c = 15;

            gameover = a > (c - 5);
            
            startGame = gameover == ( c > (a +5));
            
            Console.WriteLine("startGame = " + startGame);
            
            
            

            
            
            
            
        }
    }
}