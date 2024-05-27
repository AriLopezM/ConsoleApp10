using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    using System;

    // Clase ReparacionFrenos que hereda de Servicio
    public class ReparacionFrenos : Servicio
    {
        
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando reparación de frenos.");
        }

        
        public override double CalcularCosto()
        {
            return 100.0; // Costo de la reparación de frenos
        }

        
        public override int ObtenerTiempoServicio()
        {
            return 60; // Tiempo de la reparación de frenos en minutos
        }
    }
}
