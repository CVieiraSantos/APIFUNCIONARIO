using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApiRepositoryPattern.Data;
using WebApiRepositoryPattern.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApiRepositoryPattern.Service.IFuncionarioInterface;

/// <summary>
/// A classe FuncionarioService é onde fica toda a lógica, é ela que irá se comunicar como banco de dados.
/// </summary>
public class FuncionarioService : IFuncionarioInterface
{
    private readonly AplicationDbContext _aplicationDbContext;

    /// <summary>
    /// Para se comunicar com o banco de dados é preciso colocar o AplicationDbContext 
    /// dentro do construtor via injeção de dependencia.
    /// </summary>
    /// <param name="aplicationDbContext"></param>
    public FuncionarioService(AplicationDbContext aplicationDbContext)
    {
        this._aplicationDbContext = aplicationDbContext;
    }

    public async Task<ServiceResponse<IList<Funcionario>>> AtivaFuncionario(int id)
    {
        ServiceResponse<IList<Funcionario>> serviceResponse = new ServiceResponse<IList<Funcionario>>();

        try
        {
            var funcionario = await _aplicationDbContext.Funcionarios.FirstOrDefaultAsync(x=> x.Id == id);

            if(funcionario is null)
                serviceResponse.Dados = null;
                serviceResponse.Mensagem = "Usuário não encontrado";
                serviceResponse.Sucesso = false;
            
            funcionario.Ativo = true;
            funcionario.DataAlteracao = DateTime.Now.ToLocalTime();

            _aplicationDbContext.Funcionarios.Update(funcionario);
            await _aplicationDbContext.SaveChangesAsync();

            serviceResponse.Dados = await _aplicationDbContext.Funcionarios.ToListAsync();
        }
        catch (Exception ex)
        {
            serviceResponse.Mensagem = ex.Message;
            serviceResponse.Sucesso = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<IList<Funcionario>>> CreateFuncionario(Funcionario funcionario)
    {
        ServiceResponse<IList<Funcionario>> serviceResponse = new ServiceResponse<IList<Funcionario>>();

        try
        {   
            if(funcionario is null)
            {
                serviceResponse.Dados = null;
                serviceResponse.Mensagem = "Informar dados";
                serviceResponse.Sucesso = false;

                return serviceResponse;
            }

            await _aplicationDbContext.AddAsync(funcionario);
            await _aplicationDbContext.SaveChangesAsync();

             var department = (from d in _aplicationDbContext.Funcionarios
                        where d.Departamento == Enums.EDepartamento.Financeiro 
                        || d.Turno == Enums.ETurno.Manha
                        select d).FirstOrDefaultAsync();

          
        }
        catch (Exception e)
        {
            serviceResponse.Mensagem = e.Message;
            serviceResponse.Sucesso = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<IList<Funcionario>>> DeleteFuncionario([FromRoute] int id)
    {
        ServiceResponse<IList<Funcionario>> serviceResponse = new ServiceResponse<IList<Funcionario>>();

        try
        {
                var funcionario = await _aplicationDbContext
                .Funcionarios
            .FirstOrDefaultAsync(x=> x.Id == id);

            if(funcionario is null)
            {
                serviceResponse.Dados = null;
                serviceResponse.Mensagem = "Usuário não localizado";
                serviceResponse.Sucesso = false;
                return serviceResponse;
            }

            _aplicationDbContext.Funcionarios.Remove(funcionario);
            await _aplicationDbContext.SaveChangesAsync();

            serviceResponse.Dados = await _aplicationDbContext.Funcionarios.ToListAsync();
        }
        catch (Exception ex)
        {
            
            serviceResponse.Mensagem = ex.Message;
            serviceResponse.Sucesso  =false;
        }
        
        return serviceResponse;
        
    }

    public async Task<ServiceResponse<IList<Funcionario>>> GetFuncionario()
    {
        ServiceResponse<IList<Funcionario>> serviceResponse = new ServiceResponse<IList<Funcionario>>();
        
        try
        {
            var funcionario = serviceResponse.Dados = await _aplicationDbContext.Funcionarios.ToListAsync();

             if(funcionario.Count == 0 || string.IsNullOrEmpty(funcionario.ToString()))
                 serviceResponse.Mensagem = "Nenhum dado encontrado";
        }
        
        catch(Exception ex)
        {
            serviceResponse.Mensagem = ex.Message;
            serviceResponse.Sucesso = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<Funcionario>> GetFuncionarioById(int id)
    {
        ServiceResponse<Funcionario> serviceResponse = new ServiceResponse<Funcionario>();

        try
        {
            var funcionario = await _aplicationDbContext.Funcionarios
                .AsNoTracking()
            .FirstOrDefaultAsync(x=> x.Id == id);
            
            if(funcionario != null)
            {
                serviceResponse.Dados = funcionario;
                serviceResponse.Mensagem = "Funcionário localizado com sucesso!!!";
                serviceResponse.Sucesso = true;
            }

            else
            {
                serviceResponse.Dados = null;
                serviceResponse.Mensagem = "Funcionário não localizado";
                serviceResponse.Sucesso = false;
            }

        }
        catch (Exception e)
        {
            serviceResponse.Mensagem = e.Message;
            serviceResponse.Sucesso = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<IList<Funcionario>>> InativaFuncionario(int id)
    {
        ServiceResponse<IList<Funcionario>> serviceResponse = new ServiceResponse<IList<Funcionario>>();
        try
        {
            var funcionario = await _aplicationDbContext.Funcionarios.FirstOrDefaultAsync(x=> x.Id == id);

            if(funcionario is null)
                serviceResponse.Dados = null;
                serviceResponse.Mensagem = "Usuário não encontrado";
                serviceResponse.Sucesso = false;
            
            funcionario.Ativo = false;
            funcionario.DataAlteracao = DateTime.Now.ToLocalTime();

            _aplicationDbContext.Funcionarios.Update(funcionario);
            await _aplicationDbContext.SaveChangesAsync();

            serviceResponse.Dados = await _aplicationDbContext.Funcionarios.ToListAsync();

        }
        catch (Exception e)
        {
            
            serviceResponse.Mensagem = e.Message;
            serviceResponse.Sucesso = false;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<IList<Funcionario>>> PutFuncionario(Funcionario funcionarioEditado)
    {
        ServiceResponse<IList<Funcionario>> serviceResponse = new ServiceResponse<IList<Funcionario>>();

        try
        {
            var funcionario = await _aplicationDbContext.Funcionarios
            .AsNoTracking().FirstOrDefaultAsync(x=> x.Id == funcionarioEditado.Id);

            if(funcionario is null)
                serviceResponse.Dados = null;
                serviceResponse.Mensagem = "Usuário não encontrado";
                serviceResponse.Sucesso = false;

            funcionario.Id = funcionarioEditado.Id;
            funcionario.Nome = funcionarioEditado.Nome;
            funcionario.Sobrenome = funcionario.Sobrenome;
            funcionario.Departamento = funcionarioEditado.Departamento;
            funcionario.Turno = funcionarioEditado.Turno;
            funcionario.DataAlteracao = DateTime.Now.ToLocalTime();

            _aplicationDbContext.Funcionarios.Update(funcionarioEditado);
            await _aplicationDbContext.SaveChangesAsync();

            serviceResponse.Dados = await _aplicationDbContext.Funcionarios.ToListAsync();
        }
        catch (Exception e)
        {
            
            serviceResponse.Mensagem = e.Message;
            serviceResponse.Sucesso = false;
        }

        return serviceResponse;
    }

    

}