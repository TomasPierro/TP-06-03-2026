using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasestp
{

    // El error estaba en la clase correo electronico porque esta separado correo electronico y no lo toma como clase luego cuando implementa el Inotificable no lo toma nose porque la verda jajaj lei en google que la interfases se implementan nose se heredan pero no entiendo que esta mal
    public interface INotificable
    {
        void EnviarTexto(string Texto);
        void resetear();


    }
    public class CorreoElectronico : INotificable
    {
        public void EnviarMensaje()
        {
            Console.WriteLine($"Enviando mail:");
        }

    }

}
