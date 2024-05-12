using Microsoft.EntityFrameworkCore;
using WebApiRepositoryPattern.Data.Mappings;
using WebApiRepositoryPattern.Models;

namespace WebApiRepositoryPattern.Data;

public class AplicationDbContext : DbContext
{
    public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }

    public DbSet<Funcionario> Funcionarios { get; set; }
}