﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NicollasDavi.Models;

#nullable disable

namespace NicollasDavi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240502141242_cacl1")]
    partial class cacl1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("NicollasDavi.Models.FolhaPagamento", b =>
                {
                    b.Property<string>("FolhaId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Ano")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FuncionarioId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("ImpostoFgts")
                        .HasColumnType("REAL");

                    b.Property<double>("ImpostoInss")
                        .HasColumnType("REAL");

                    b.Property<double>("ImpostoIrrf")
                        .HasColumnType("REAL");

                    b.Property<int>("Mes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<double>("SalarioBruto")
                        .HasColumnType("REAL");

                    b.Property<double>("SalarioLiquido")
                        .HasColumnType("REAL");

                    b.Property<int>("Valor")
                        .HasColumnType("INTEGER");

                    b.HasKey("FolhaId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("FolhaPagamento");
                });

            modelBuilder.Entity("NicollasDavi.Models.Funcionario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("NicollasDavi.Models.FolhaPagamento", b =>
                {
                    b.HasOne("NicollasDavi.Models.Funcionario", null)
                        .WithMany("FolhaPagamento")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NicollasDavi.Models.Funcionario", b =>
                {
                    b.Navigation("FolhaPagamento");
                });
#pragma warning restore 612, 618
        }
    }
}
