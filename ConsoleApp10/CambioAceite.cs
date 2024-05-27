using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    using System;

    // Clase CambioAceite que hereda de Servicio
    public class CambioAceite : Servicio
    {
        
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando cambio de aceite.");
        }

        
        public override double CalcularCosto()
        {
            return 50.0; // Costo del cambio de aceite
        }

        
        public override int ObtenerTiempoServicio()
        {
            return 30; // Tiempo del cambio de aceite en minutos
        }
    }
}
