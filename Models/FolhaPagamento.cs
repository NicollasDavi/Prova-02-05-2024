using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NicollasDavi.Models;

public class FolhaPagamento{

    [Key]
    public string FolhaId {get; set;}
    public int Valor {get; set;}
    public int Quantidade {get; set;}
    public int Mes {get; set;}

   [ForeignKey("Id")]
    public string FuncionarioId {get; set;}   
}