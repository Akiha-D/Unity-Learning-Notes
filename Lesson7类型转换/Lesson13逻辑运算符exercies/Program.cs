using System;
using System.Numerics;

namespace Lesson13exercies
{
    class Program       
    {
        static void Main(string[] age)
        {   
            
            //1.
            // true 
            // false || true //true
            // true && true //true
            // true && false //false
            // !ture //false
            
            //2.
            bool gameOver;
            bool isWin;
            int health = 100;
            gameOver = true;
            isWin = false;
            
            Console.WriteLine(gameOver || isWin && health > 0);
            // &&优先 
            //
            //flase && ture //flase
            //true ||flase // ture

        }
    }
}