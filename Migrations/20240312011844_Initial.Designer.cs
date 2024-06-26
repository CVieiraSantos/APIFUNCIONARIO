﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiRepositoryPattern.Data;

#nullable disable

namespace WebApiRepositoryPattern.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20240312011844_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApiRepositoryPattern.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("BIT");

                    b.Property<DateTime>("DataAlteracao")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(60)
                        .HasColumnType("SMALLDATETIME")
                        .HasDefaultValue(new DateTime(2024, 3, 11, 22, 18, 44, 348, DateTimeKind.Local).AddTicks(5931));

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(60)
                        .HasColumnType("SMALLDATETIME")
                        .HasDefaultValue(new DateTime(2024, 3, 11, 22, 18, 44, 348, DateTimeKind.Local).AddTicks(5348));

                    b.Property<int>("Departamento")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR");

                    b.Property<int>("Turno")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Nome" }, "IX_Funcionario_Nome")
                        .IsUnique();

                    b.ToTable("TBFuncionario", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
