using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    using System;

    // Clase Moto que hereda de Vehiculo
    public class Moto : Vehiculo
    {
       
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento de la moto: Lubricación de cadena y revisión de neumáticos.");
        }

        
        public override decimal ObtenerCostoMantenimiento()
        {
            return 70m; // Costo del mantenimiento de la moto
        }

        
        public override int ObtenerTiempoMantenimiento()
        {
            return 60; // Tiempo del mantenimiento de la moto en minutos
        }

        
        public override void Lavar()
        {
            Console.WriteLine("Lavando la moto.");
        }
    }
}
