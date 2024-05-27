using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




// Clase abstracta Vehiculo que define el esquema general de un vehículo
public abstract class Vehiculo
{
    
    public abstract void RealizarMantenimiento();

    
    public abstract decimal ObtenerCostoMantenimiento();

    
    public abstract int ObtenerTiempoMantenimiento(); // Tiempo en minutos

    
    public virtual void Lavar()
    {
        Console.WriteLine("Lavando el vehículo genérico.");
    }
}