using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasestp
{
    // EL error estaba en que el valor mortordelcoche no tiene nada esta vacio. por eso le hice el contructor a la clase coche. en este no tenia tanta idea use gemini y me decia que iva a fallar porque motordelcoche estaba vacia.
    public class Motor
    {
        public void Encender()  { Console.WriteLine("encendido.");}
    }
    public class Coche 
    {
        public Motor motordelcoche { get; set; }

        public Coche()
        {          
            motordelcoche = new Motor();
        }
        public void Arrancar()
        {
            motordelcoche.Encender();
        }
    }
}
