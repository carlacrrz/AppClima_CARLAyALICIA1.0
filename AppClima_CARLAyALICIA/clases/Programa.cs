using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Programa
{
    public static async Task Main()
    {
        var cliente = new ClienteCalidadAire();

        if (!await cliente.VerificarSaludAsync())
        {
            Console.WriteLine("API no disponible");
            return;
        }

        var sensores = await cliente.ObtenerSensoresAsync();
        Console.WriteLine($"Sensores disponibles: {sensores.Count}");

        var lecturas = await cliente.ObtenerTodasLasLecturasAsync(10);
        Console.WriteLine($"Lecturas obtenidas: {lecturas.Cantidad}");

        var calculador = new CalculadorMeteorologico(lecturas.Datos);

        Console.WriteLine($"Resumen: {calculador.ObtenerResumenMeteorologico()}");
        Console.WriteLine($"Índice de calor: {calculador.CalcularIndiceCalor()}°C");
        Console.WriteLine($"Punto de rocío: {calculador.CalcularPuntoRocio()}°C");

        var calidadAire = calculador.CalcularCalidadAire();
        foreach (var contaminante in calidadAire)
        {
            Console.WriteLine($"{contaminante.Key}: {contaminante.Value}");
        }
    }
}
