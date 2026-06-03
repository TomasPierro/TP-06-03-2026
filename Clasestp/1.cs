namespace Clasestp
{

    // el error estaba en el constructor del la clase auto y faltaba el base para la herencia.
    public class Vehiculo
    {
        public string Marca { get; set; }
        public Vehiculo(string marca)
        {
            Marca = marca;
        }
    }
    public class Auto : Vehiculo
    {
        public int puertas { get; set; }
        public Auto(string marca, int puertas) : base(marca)
        {
            Marca = marca;
        }
    }
}
