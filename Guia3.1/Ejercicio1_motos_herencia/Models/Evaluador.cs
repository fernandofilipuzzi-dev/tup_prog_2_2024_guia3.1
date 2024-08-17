

namespace Ejercicio1.Models
{
    abstract public class Evaluador
    {
        protected int añoACalcular;
        public int AñoACalcular
        {
            get 
            {
                return añoACalcular;
            }
        }

        public Moto vehiculo;
        public Moto Vehiculo
        {
            get 
            {
                return vehiculo;
            }
        }

        public Evaluador(Moto vehiculo, int añoACalcular)
        {
            this.vehiculo = vehiculo;
        }

        abstract public double CalcularDepreciacion();
        virtual public string VerDescripcion()
        {
            return $"Vehículo: {Vehiculo.VerDescripcion()}";
        }

    }
}
