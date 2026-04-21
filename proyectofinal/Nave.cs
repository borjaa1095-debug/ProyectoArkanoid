using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectofinal
{
    internal class Nave
    {
        public Nave()
        {

        }

        public void DibujarNave(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("/\\");
        }

        public void BorrarNave(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }

        public void MoverNave(ref int x)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);

                if (tecla.Key == ConsoleKey.LeftArrow && x > 2)
                {
                    x--;
                }
                else if (tecla.Key == ConsoleKey.RightArrow && x < Console.WindowWidth-2)
                {
                    x++;
                }
            }
        }
    }
}
