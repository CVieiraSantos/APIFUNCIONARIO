using System.Text.Json.Serialization;
namespace WebApiRepositoryPattern.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ETurno
{
    Manha,
    Tarde,
    Noite
}