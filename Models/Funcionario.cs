namespace NicollasDavi.Models;

public class Funcionario{
    public string Id {get; set;}
    public string Cpf {get; set;}
    public string Nome {get; set;}

    public ICollection<FolhaPagamento> FolhaPagamento { get; } = new List<FolhaPagamento>();

    public Funcionario(string nome, string cpf){
        Id = Guid.NewGuid().ToString();
        Nome = nome;
        Cpf = cpf;
    }
}