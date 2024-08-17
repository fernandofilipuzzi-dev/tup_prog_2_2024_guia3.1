using System;

namespace Ejercicio1.Models
{
    public class EvaluadorAnual : Evaluador
    {
        public double TasaDepreciacion { get; set; }
        

        public EvaluadorAnual(Moto vehiculo, int añoACalcular, double tasaDepreciacion) : base(vehiculo, añoACalcular)
        {
            TasaDepreciacion = tasaDepreciacion;
            this.añoACalcular = añoACalcular;
        }

        override public double CalcularDepreciacion()
        {
            double valor= Vehiculo.ValorFabricacion * (Math.Pow(1 - TasaDepreciacion, AñoACalcular - Vehiculo.Modelo));
            return valor;
        }

        override public string VerDescripcion()
        {
            return 
$@"
   {base.VerDescripcion()}
   Tipo de evaluación Anual, monto:{CalcularDepreciacion()};
";
        }
    }
}
