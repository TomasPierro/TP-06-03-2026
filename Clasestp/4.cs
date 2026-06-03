using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasestp
{
    // el error estaba en el metodo termomentro, porque se repite el nombre luego le puse un console a temperatura en el metodo actualizar para mostrar la temperatura en grados celsius y para lo del programa de consola para que no se salte la validacion podria hacer un if para que la temperatura ingresada sea entre -50 y 100 grados
    public class Termomentro
    {
        public double Temperatura { get; set; }


        public Termomentro(double temperatura)
        {
            Temperatura = temperatura;
        }
        public void termomentro()
        {
            Temperatura = 20;
        }
        public void Actualizar(double Lecturasensor)
        {
            if (Lecturasensor >= -50.0 && Lecturasensor <= 100.0)
            {
                Temperatura = Lecturasensor;
                Console.WriteLine($"Temperatura actualizada a: {Temperatura} °C");
            }
            else
            {
                Console.WriteLine("ERROR , lectura extrema ignorada.");
            }

        }
    }
}