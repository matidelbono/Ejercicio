using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Principal
    {
      
        List<Prestamo> Prestamos = new List<Prestamo>();
        


        public bool RegistrarPrestamo(DateTime fecha, decimal Monto, string NombreyApellidoCliente, int CuitCliente, DateTime FechaPrestamo, decimal MontoTotalCredito, decimal Tasainteres, int CantidadCuotas)
        {
            if (fecha >= DateTime.Today)
             {
                Prestamo nuevoPrestamo = new Prestamo(NombreyApellidoCliente, CuitCliente, FechaPrestamo, MontoTotalCredito, Tasainteres, CantidadCuotas);
                Prestamos.Add(nuevoPrestamo);
                return true;
            }
            return false;
        }
          List<PrestamoPorFecha>ObtenerPrestamosPorFecha(DateTime fecha1, DateTime fecha2)
        {
            List<PrestamoPorFecha> PrestamoaFecha = new List<PrestamoPorFecha>();
            foreach (var item in Prestamos)
            {
                if(item.FechaPrestamo>=fecha1 & item.FechaPrestamo<=fecha2)
                {
                    PrestamoPorFecha porFecha = new PrestamoPorFecha();
                    porFecha.NombreaDevolver = item.NombreApellidoCliente;
                    porFecha.FechaPrestamoaDevolver = item.FechaPrestamo;
                    porFecha.InteresaDevolver = item.TasaInteres;
                    porFecha.MontoPrestamoaDevolver = item.MontoTotalCredito;

               }
               

            }
            return PrestamoaFecha;

        }

    }
}




