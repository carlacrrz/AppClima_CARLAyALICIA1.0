using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

//esta clase es para obtener la info de los sensores q vienen en la api, el id, modelo q seria el nombre del sensor y variables q miden
public class InformacionSensor
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("model")]
    public string Modelo { get; set; }

    [JsonPropertyName("measures")]
    public List<string> Variables { get; set; }
}

//esta clase es para obtener los datos del sensor ahora si todas las varibales q lleva
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

//esta clase es para obtener todas las muestras q vienen en la api
public class Muestras
{
    [JsonPropertyName("data")]
    public List<Muestra> Datos { get; set; }

    [JsonPropertyName("count")]
    public int Cantidad { get; set; }
}
