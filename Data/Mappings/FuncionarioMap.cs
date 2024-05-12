using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiRepositoryPattern.Enums;
using WebApiRepositoryPattern.Models;

namespace WebApiRepositoryPattern.Data.Mappings;

public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
{
    public void Configure(EntityTypeBuilder<Funcionario> builder)
    {
        builder.ToTable("TBFuncionario");

        builder.HasKey(x=> x.Id);

        builder.Property(x=> x.Id)
        .UseIdentityColumn()
        .ValueGeneratedOnAdd();

        builder.Property(x=> x.Nome)
        .IsRequired()
        .HasColumnType("NVARCHAR")
        .HasMaxLength(30);

        builder.Property(x=> x.Sobrenome)
        .IsRequired()
        .HasColumnType("NVARCHAR")
        .HasMaxLength(30);

        builder.Property(x=> x.Departamento)
        .IsRequired()
        .HasColumnType("NVARCHAR")
        .HasMaxLength(20)
        .HasConversion(
            v=> v.ToString(),
            v=> (EDepartamento)Enum.Parse(typeof(EDepartamento), v)
        );
        
        builder.Property(x=> x.Ativo)
        .IsRequired()
        .HasColumnType("BIT");

        builder.Property(x=> x.Turno)
        .IsRequired()
        .HasColumnType("NVARCHAR")
        .HasMaxLength(20)
        .HasConversion(
           v=> v.ToString(),
           v=>(ETurno)Enum.Parse(typeof(ETurno), v)
        );

        builder.Property(x=> x.DataCriacao)
        .IsRequired()
        .HasColumnType("SMALLDATETIME")
        .HasMaxLength(60)
        .HasDefaultValue(DateTime.Now.ToLocalTime());

        builder.Property(x=> x.DataAlteracao)
        .IsRequired()
        .HasMaxLength(60)
        .HasColumnType("SMALLDATETIME")
        .HasDefaultValue(DateTime.Now.ToLocalTime());

        builder.HasIndex(x=> x.Nome, "IX_Funcionario_Nome")
        .IsUnique();
    }
}