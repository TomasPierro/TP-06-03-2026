using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasestp
{
  // esta mal porque el metodo realizarTarea no es virtual, por lo que no se puede sobreescribir en la clase programador.
    public class Trabajador
    {
        public void realizarTarea()
        {
            Console.WriteLine("El trabajador hace tareas generales.");
        }
    }
    public class Programador : Trabajador
    {
        public void rTarea()
        {
            Console.WriteLine("El programador escribe código en c#.");
        }

    }
}
