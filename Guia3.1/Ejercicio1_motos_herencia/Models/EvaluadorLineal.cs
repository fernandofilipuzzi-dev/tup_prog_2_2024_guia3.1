
namespace Ejercicio1.Models
{
    public class EvaluadorLineal:Evaluador
    {
        public int VidaUtil { get; set; }

        public EvaluadorLineal(Moto vehiculo, int añoACalcular,int vidaUtil) : base(vehiculo, añoACalcular)
        {
            VidaUtil = vidaUtil;
            this.añoACalcular = añoACalcular;
        }

        override public double CalcularDepreciacion()
        {
            int añosDeUso = AñoACalcular - Vehiculo.Modelo;
            
            double valor = 0;

            if (VidaUtil > 0 && añosDeUso > 0)
            {
                valor = Vehiculo.ValorFabricacion - (Vehiculo.ValorFabricacion * añosDeUso / VidaUtil);
            }

            return valor;
        }

        override public string VerDescripcion()
        {
            return
$@"
   {base.VerDescripcion()}
   Tipo de evaluación lineal, monto:{CalcularDepreciacion()};
";
        }
    }
}
