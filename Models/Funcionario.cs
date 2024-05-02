namespace NicollasDavi.Models;

public class Funcionario{
    public string id {get; set;}
    public string cpf {get; set;}
    public string nome {get; set;}

    public ICollection<FolhaPagamento> FolhaPagamento { get; } = new List<FolhaPagamento>();

    public Funcionario(string nome, string cpf){
        id = Guid.NewGuid().ToString();
        nome = nome;
        cpf = cpf;
    }
}