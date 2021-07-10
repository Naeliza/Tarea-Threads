using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class Hilos : Metodos //Herencia
    {
        public override void CogerLLamada()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(i + "-" + "La persona habla por telefono");
                Console.ResetColor();
                Thread.Sleep(500);
            }
        }

        public override void Conducir()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.ResetColor();
                Console.WriteLine(i + "-" + "La persona esta conduciendo");
                Thread.Sleep(500);
            }
        }
    }
}
