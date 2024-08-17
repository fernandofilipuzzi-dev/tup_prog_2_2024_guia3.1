

namespace Ejercicio1.Models
{
    public class Moto
    {
        public string Marca{ get; private set; }
        public int Modelo { get; private set; }
        public double ValorFabricacion { get; private set; }

        public Moto(string marca, int modelo, double valorFabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }
              
        public string VerDescripcion()
        {
            return $"Marca:{Marca}, Modelo:{Modelo}, Valor Fabriación:${ValorFabricacion,10:f2}";
        }

    }
}
