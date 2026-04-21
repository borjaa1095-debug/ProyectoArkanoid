using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectofinal
{
    internal class Motor
    {
        public void ConfigurarConsola()
        {
            Console.SetWindowSize(80, 25);
            Console.CursorVisible = false;
            Console.Clear();
        }

        public void DibujarMarcos()
        {
            int alto = 80;
            int ancho = 25;

            for(int i=0; i < alto; i++)
            {
                for(int j=0; j < ancho; j++)
                {
                    if(i == 0 || i == alto - 1)
                    {
                        Console.Write("-");
                    }
                    else if(j == 0 || j == ancho - 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void BucleJuego()
        {

        }
    }
}
