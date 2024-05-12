using Microsoft.EntityFrameworkCore;
using WebApiRepositoryPattern.Data;
using WebApiRepositoryPattern.Models;
using WebApiRepositoryPattern.Service.IFuncionarioInterface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IFuncionarioInterface,FuncionarioService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AplicationDbContext>(
    x=> x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
