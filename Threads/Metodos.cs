using System;
using System.Collections.Generic;
using System.Text;

namespace Threads
{
    abstract class Metodos //Usando metodos abstractos porque quiero que se usen obligatoriamente y cambiar su proceso desde otra clase
    {
        public abstract void Conducir();

        public abstract void CogerLLamada();
    }
}
