using ConsoleApp10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Program
{
    static void Main(string[] args)
    {
        // Trabajando con Vehiculo y sus derivadas

        // Polimorfismo: Vehiculo puede hacer referencia a cualquier objeto de clase derivada
        Vehiculo miCoche = new Coche();
        miCoche.RealizarMantenimiento();
        Console.WriteLine("Costo del mantenimiento del coche: $" + miCoche.ObtenerCostoMantenimiento());
        miCoche.Lavar();

        Vehiculo miMoto = new Moto();
        miMoto.RealizarMantenimiento();
        Console.WriteLine("Costo del mantenimiento de la moto: $" + miMoto.ObtenerCostoMantenimiento());
        miMoto.Lavar();

        // Llamando al método Lavar() que pertenece a la clase Coche, no al tipo Vehiculo
        Coche miCocheReal = new Coche();
        miCocheReal.Lavar();

        // Trabajando con Servicio y sus derivadas

        // Polimorfismo: Servicio puede hacer referencia a cualquier objeto de clase derivada
        Servicio servicioAceite = new CambioAceite();
        servicioAceite.RealizarServicio();
        Console.WriteLine("Costo del cambio de aceite: $" + servicioAceite.CalcularCosto());

        Servicio servicioFrenos = new ReparacionFrenos();
        servicioFrenos.RealizarServicio();
        Console.WriteLine("Costo de la reparación de frenos: $" + servicioFrenos.CalcularCosto());

        // Calcular tiempo total de los servicios
        List<Servicio> servicios = new List<Servicio> { servicioAceite, servicioFrenos };
        CalcularTiempoTotal(miCoche, servicios);
    }

    // Método para calcular el tiempo total de los servicios e informarlo al cliente
    static void CalcularTiempoTotal(Vehiculo vehiculo, List<Servicio> servicios)
    {
        int tiempoTotal = vehiculo.ObtenerTiempoMantenimiento();
        foreach (var servicio in servicios)
        {
            tiempoTotal += servicio.ObtenerTiempoServicio();
        }
        Console.WriteLine($"El tiempo total para el mantenimiento y servicios adicionales del vehículo es: {tiempoTotal} minutos.");
    }
}