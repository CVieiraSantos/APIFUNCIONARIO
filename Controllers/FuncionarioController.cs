using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApiRepositoryPattern.Models;
using WebApiRepositoryPattern.Service.IFuncionarioInterface;

namespace WebApiRepositoryPattern.Controllers;

[ApiController]
//[Route("api/{controller}")]
public class FuncionarioController : ControllerBase
{
    private readonly IFuncionarioInterface _funcionarioService;

    public FuncionarioController(IFuncionarioInterface funcionarioInterface)
    {
        this._funcionarioService = funcionarioInterface;
    }
   
    [HttpGet("v1/funcionario")]
    public async Task<ActionResult<ServiceResponse<IList<Funcionario>>>> GetFuncionario()
    {
        var funcionario = await _funcionarioService.GetFuncionario();
        return Ok(funcionario);
    }

    [HttpGet("v1/funcionario/{id:int}")]
    public async Task<ActionResult<ServiceResponse<Funcionario>>> GetEmployeeById(int id)
    {
        var funcionario = await _funcionarioService.GetFuncionarioById(id);

        return Ok(funcionario);
    }


    [HttpPost("v1/funcionario")]
    public async Task<ActionResult<ServiceResponse<IList<Funcionario>>>> CreateFuncionarioAsync(Funcionario funcionario)
    {
        var employee = await _funcionarioService.CreateFuncionario(funcionario);
        return Ok(employee);
    }

    
    [HttpPut("v1/funcionario/inativaFuncionarioPeloId")]
    public async Task<ActionResult<ServiceResponse<IList<Funcionario>>>> InativaFuncionarioAsync(int id)
    {
        ServiceResponse<IList<Funcionario>> serviceResponse = await _funcionarioService.InativaFuncionario(id); 
        return Ok(serviceResponse);
    }

    [HttpPut("v1/funcionario/ativaFuncionarioPeloId")]
    public async Task<ActionResult<ServiceResponse<IList<Funcionario>>>> AtivaFuncionarioAsync(int id)
    {
        ServiceResponse<IList<Funcionario>> serviceResponse = await _funcionarioService.AtivaFuncionario(id); 
        return Ok(serviceResponse);
    }

    [HttpPut("v1/funcionario")]
    public async Task<ActionResult<ServiceResponse<IList<Funcionario>>>> UpdateFuncionario(Funcionario funcionarioEditado)
    {
        ServiceResponse<IList<Funcionario>> serviceResponse = await _funcionarioService.PutFuncionario(funcionarioEditado); 
        return Ok(serviceResponse);
    }

    [HttpDelete("v1/funcionario/{id:int}")]
    public async Task<ActionResult<ServiceResponse<IList<Funcionario>>>> DeleteFuncionario(int id)
    {
        ServiceResponse<IList<Funcionario>> serviceResponse = await _funcionarioService.DeleteFuncionario(id); 
        return Ok(serviceResponse);
    }
}