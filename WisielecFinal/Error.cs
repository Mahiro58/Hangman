using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisielecFinal
{
    internal class Error
    {
        public static void DrawHangman(int errors)
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("-----");
            Console.WriteLine("|   |");

            if (errors >= 1)
                Console.WriteLine("|   O");   // Głowa
            else
                Console.WriteLine("|");

            if (errors >= 3)
                Console.WriteLine("|  /|\\");  // Ręce
            else if (errors == 2)
                Console.WriteLine("|  /|");
            else
                Console.WriteLine("|");

            if (errors >= 5)
                Console.WriteLine("|  / \\");  // Nogi
            else if (errors == 4)
                Console.WriteLine("|  /");
            else
                Console.WriteLine("|");

            Console.WriteLine("|");
            Console.WriteLine("=====");
        }        
    }
}
