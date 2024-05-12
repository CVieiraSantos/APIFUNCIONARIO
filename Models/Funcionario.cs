using WebApiRepositoryPattern.Enums;

namespace WebApiRepositoryPattern.Models;

public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string Sobrenome { get; set; } = null!;
    public EDepartamento Departamento { get; set; }
    public bool Ativo { get; set; }
    public ETurno Turno { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now.ToLocalTime();
    public DateTime DataAlteracao { get; set; } = DateTime.Now.ToLocalTime();
}