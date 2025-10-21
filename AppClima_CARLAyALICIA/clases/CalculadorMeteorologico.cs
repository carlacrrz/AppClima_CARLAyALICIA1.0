using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CalculadorMeteorologico
{
    private List<Muestra> _muestras;

    public CalculadorMeteorologico(List<Muestra> muestras)
    {
        _muestras = muestras;
    }

    public double CalcularTemperaturaMedia()
    {
        var temperaturas = _muestras
            .Where(m => m.Variable == "TEMP")
            .Select(m => m.Valor);

        return temperaturas.Any() ? temperaturas.Average() : 0;
    }

    public double CalcularHumedadRelativaMedia()
    {
        var humedades = _muestras
            .Where(m => m.Variable == "RH")
            .Select(m => m.Valor);

        return humedades.Any() ? humedades.Average() : 0;
    }

    public double CalcularPresionAtmosfericaMedia()
    {
        var presiones = _muestras
            .Where(m => m.Variable == "PRESS")
            .Select(m => m.Valor);

        return presiones.Any() ? presiones.Average() : 0;
    }

    public double CalcularVelocidadVientoMedia()
    {
        var velocidades = _muestras
            .Where(m => m.Variable == "WIND_SPEED")
            .Select(m => m.Valor);

        return velocidades.Any() ? velocidades.Average() : 0;
    }

    public string ObtenerDireccionVientoPredominante()
    {
        var direcciones = _muestras
            .Where(m => m.Variable == "WIND_DIR")
            .Select(m => m.Valor);

        if (!direcciones.Any()) return "Desconocida";

        var direccionMedia = direcciones.Average();

        if (direccionMedia >= 337.5 || direccionMedia < 22.5) return "Norte";
        if (direccionMedia >= 22.5 && direccionMedia < 67.5) return "Noreste";
        if (direccionMedia >= 67.5 && direccionMedia < 112.5) return "Este";
        if (direccionMedia >= 112.5 && direccionMedia < 157.5) return "Sureste";
        if (direccionMedia >= 157.5 && direccionMedia < 202.5) return "Sur";
        if (direccionMedia >= 202.5 && direccionMedia < 247.5) return "Suroeste";
        if (direccionMedia >= 247.5 && direccionMedia < 292.5) return "Oeste";
        return "Noroeste";
    }

    public double CalcularIndiceCalor()
    {
        var temperatura = CalcularTemperaturaMedia();
        var humedad = CalcularHumedadRelativaMedia();

        if (temperatura < 27) return temperatura;

        double indiceCalor = -8.78469475556 +
                            1.61139411 * temperatura +
                            2.33854883889 * humedad +
                            -0.14611605 * temperatura * humedad +
                            -0.012308094 * temperatura * temperatura +
                            -0.0164248277778 * humedad * humedad +
                            0.002211732 * temperatura * temperatura * humedad +
                            0.00072546 * temperatura * humedad * humedad +
                            -0.000003582 * temperatura * temperatura * humedad * humedad;

        return Math.Round(indiceCalor, 2);
    }

    public double CalcularProbabilidadLluvia()
    {
        var humedad = CalcularHumedadRelativaMedia();
        var presion = CalcularPresionAtmosfericaMedia();
        var precipitacion = CalcularPrecipitacionAcumulada();

        double probabilidad = (humedad - 50) * 1.2;
        if (presion < 1010) probabilidad += 20;
        if (precipitacion > 0) probabilidad += 30;

        return Math.Max(0, Math.Min(100, probabilidad));
    }

    public double CalcularPuntoRocio()
    {
        var temperatura = CalcularTemperaturaMedia();
        var humedad = CalcularHumedadRelativaMedia();

        double puntoRocio = temperatura - ((100 - humedad) / 5);
        return Math.Round(puntoRocio, 2);
    }

    public double CalcularIndiceUVMaximo()
    {
        var uv = _muestras
            .Where(m => m.Variable == "UV")
            .Select(m => m.Valor);

        return uv.Any() ? uv.Max() : 0;
    }

    public double CalcularPrecipitacionAcumulada()
    {
        var lluvia = _muestras
            .Where(m => m.Variable == "RAIN")
            .Select(m => m.Valor);

        return lluvia.Any() ? lluvia.Sum() / 3600 : 0;
    }

    public Dictionary<string, double> CalcularCalidadAire()
    {
        var calidad = new Dictionary<string, double>();

        var pm25 = _muestras.Where(m => m.Variable == "PM2.5").Select(m => m.Valor);
        var pm10 = _muestras.Where(m => m.Variable == "PM10").Select(m => m.Valor);
        var o3 = _muestras.Where(m => m.Variable == "O3").Select(m => m.Valor);
        var no2 = _muestras.Where(m => m.Variable == "NO2").Select(m => m.Valor);
        var so2 = _muestras.Where(m => m.Variable == "SO2").Select(m => m.Valor);
        var co = _muestras.Where(m => m.Variable == "CO").Select(m => m.Valor);

        if (pm25.Any()) calidad.Add("PM2.5", pm25.Average());
        if (pm10.Any()) calidad.Add("PM10", pm10.Average());
        if (o3.Any()) calidad.Add("O3", o3.Average());
        if (no2.Any()) calidad.Add("NO2", no2.Average());
        if (so2.Any()) calidad.Add("SO2", so2.Average());
        if (co.Any()) calidad.Add("CO", co.Average());

        return calidad;
    }

    public List<string> ObtenerRecomendaciones()
    {
        var recomendaciones = new List<string>();

        var uv = CalcularIndiceUVMaximo();
        if (uv > 6) recomendaciones.Add("Usa protector solar");
        if (uv > 8) recomendaciones.Add("Usa lentes de sol");

        var temp = CalcularTemperaturaMedia();
        if (temp > 30)
        {
            recomendaciones.Add("Mantente hidratado");
            recomendaciones.Add("Usa gorra o sombrero");
        }
        if (temp < 15) recomendaciones.Add("Usa chamarra abrigadora");

        var lluvia = CalcularProbabilidadLluvia();
        if (lluvia > 60) recomendaciones.Add("Lleva paraguas o impermeable");

        var viento = CalcularVelocidadVientoMedia();
        if (viento > 10) recomendaciones.Add("Ten cuidado con vientos fuertes");

        var calidadAire = CalcularCalidadAire();
        if (calidadAire.ContainsKey("PM2.5") && calidadAire["PM2.5"] > 35)
            recomendaciones.Add(" Evita actividades al aire libre");

        var humedad = CalcularHumedadRelativaMedia();
        if (humedad > 85) recomendaciones.Add("Ropa cómoda por humedad");

        if (!recomendaciones.Any())
            recomendaciones.Add("Condiciones ideales para actividades al aire libre");

        return recomendaciones;
    }
}
