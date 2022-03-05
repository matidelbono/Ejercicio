using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
   public abstract class Cliente
    {
       public string Nombre { get; set; }
       public string Apellido { get; set; }
       public int Cuit { get; set; }
       public DateTime FechaNacimiento { get; set; }
       public decimal SueldoNeto { get; set; }
       public int CantidadHijos { get; set; }
       public bool EstaCasado { get; set; }
       public decimal CalcularGastosFijos()
        {
            if (EstaCasado==true)
            {
                decimal PrimeraResta = SueldoNeto - 20 / 100;
                decimal GastosFijosDefinitivos = PrimeraResta - (CantidadHijos * 5 / 100);
                return GastosFijosDefinitivos;
            }
            return 0;
            
        }
        public abstract decimal ObtenerTasaInteres();
        public abstract decimal CalcularMontoMaximoPrestamo()
     }
}





