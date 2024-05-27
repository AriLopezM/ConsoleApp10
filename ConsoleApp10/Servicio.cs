using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    using System;

    // Clase abstracta Servicio que define el esquema general de un servicio
    public abstract class Servicio
    {
        
        public abstract void RealizarServicio();

        
        public abstract double CalcularCosto();

        
        public abstract int ObtenerTiempoServicio(); // Tiempo en minutos
    }
}
