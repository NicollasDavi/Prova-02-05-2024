using Microsoft.EntityFrameworkCore;

namespace NicollasDavi.Models;

public class AppDbContext : DbContext
{

    public DbSet<Funcionario> Funcionario { get; set; }

    public DbSet<FolhaPagamento> FolhaPagamento { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("Data Source=NicollasDavi_LeonardoMartinez.db");

    }
}