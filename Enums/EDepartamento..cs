using System.Text.Json.Serialization;

namespace WebApiRepositoryPattern.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EDepartamento
{
    RH,
    Financeiro,
    Compras,
    Atendimento,
    Zeladoria
}