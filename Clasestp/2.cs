using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasestp
{
    //el error estaba en el metodo sumar, ya que no se puede tener dos metodos con el mismo nombre 
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }
        public double sumar(int x, int y)
        {
            return (double)x + y;
        }
    }
}
