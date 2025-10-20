using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class InformacionSensor
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("model")]
    public string Modelo { get; set; }

    [JsonPropertyName("measures")]
    public List<string> Variables { get; set; }
}

public class Muestra
{
    [JsonPropertyName("sensor_id")]
    public string IdSensor { get; set; }

    [JsonPropertyName("variable")]
    public string Variable { get; set; }

    [JsonPropertyName("value")]
    public double Valor { get; set; }

    [JsonPropertyName("unit")]
    public string Unidad { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime FechaHora { get; set; }
}

public class Muestras
{
    [JsonPropertyName("data")]
    public List<Muestra> Datos { get; set; }

    [JsonPropertyName("count")]
    public int Cantidad { get; set; }
}
