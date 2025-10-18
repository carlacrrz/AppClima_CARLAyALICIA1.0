using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class ClienteCalidadAire
{
    private readonly HttpClient _clienteHttp;
    private const string UrlBase = "http://localhost:8000";

    public ClienteCalidadAire()
    {
        _clienteHttp = new HttpClient { BaseAddress = new Uri(UrlBase) };
    }

    public async Task<List<InformacionSensor>> ObtenerSensoresAsync()
    {
        var respuesta = await _clienteHttp.GetAsync("/sensors");
        respuesta.EnsureSuccessStatusCode();
        var contenido = await respuesta.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<InformacionSensor>>(contenido);
    }

    public async Task<Muestras> ObtenerTodasLasLecturasAsync(int cantidad = 1, int? semilla = null)
    {
        var url = $"/readings?n={cantidad}";
        if (semilla.HasValue)
            url += $"&seed={semilla.Value}";

        var respuesta = await _clienteHttp.GetAsync(url);
        respuesta.EnsureSuccessStatusCode();
        var contenido = await respuesta.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<Muestras>(contenido);
    }

    public async Task<Muestras> ObtenerLecturasSensorAsync(string idSensor, int cantidad = 1, int? semilla = null)
    {
        var url = $"/reading/{idSensor}?n={cantidad}";
        if (semilla.HasValue)
            url += $"&seed={semilla.Value}";

        var respuesta = await _clienteHttp.GetAsync(url);
        respuesta.EnsureSuccessStatusCode();
        var contenido = await respuesta.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<Muestras>(contenido);
    }

    public async Task<bool> VerificarSaludAsync()
    {
        try
        {
            var respuesta = await _clienteHttp.GetAsync("/health");
            return respuesta.IsSuccessStatusCode;
        }
        catch
        {
            return false;
        }
    }
}
