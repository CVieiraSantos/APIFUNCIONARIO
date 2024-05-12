using WebApiRepositoryPattern.Models;

namespace WebApiRepositoryPattern.Service.IFuncionarioInterface;

public interface IFuncionarioInterface
{
    Task<ServiceResponse<IList<Funcionario>>> GetFuncionario();
    Task<ServiceResponse<Funcionario>> GetFuncionarioById(int id);
    Task<ServiceResponse<IList<Funcionario>>> CreateFuncionario(Funcionario funcionario);
    Task<ServiceResponse<IList<Funcionario>>> PutFuncionario(Funcionario funcionario);
    Task<ServiceResponse<IList<Funcionario>>> DeleteFuncionario(int funcionario);
    Task<ServiceResponse<IList<Funcionario>>> InativaFuncionario(int funcionario);
}