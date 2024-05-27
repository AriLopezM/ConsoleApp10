using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    using System;

    // Clase Coche que hereda de Vehiculo
    public class Coche : Vehiculo
    {
       
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento del coche: Cambio de aceite y revisión de frenos.");
        }

        
        public override decimal ObtenerCostoMantenimiento()
        {
            return 150m; // Costo del mantenimiento del coche
        }

        
        public override int ObtenerTiempoMantenimiento()
        {
            return 120; // Tiempo del mantenimiento del coche en minutos
        }

        
        public new void Lavar()
        {
            Console.WriteLine("Lavando el coche con cera y shampoo especial.");
        }
    }
}
