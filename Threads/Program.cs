using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Hilos hilos = new Hilos();
            Thread t1 = new Thread(hilos.Conducir);
            t1.Start();
            hilos.CogerLLamada();
        }
    }
}


