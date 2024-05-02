using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using  NicollasDavi.Models;

namespace NicollasDavi.Models;

public class FolhaPagamento{

    [Key]
    public string FolhaId {get; set;}
    public int Valor {get; set;}
    public int Quantidade {get; set;}
    public int Mes {get; set;}

    public int Ano {get; set;}

    public double SalarioBruto {get; set;}

    public double ImpostoIrrf {get;set;}

    public double ImpostoInss {get; set;}

    public double ImpostoFgts {get; set;}

    public double SalarioLiquido {get; set;}

    [ForeignKey("Id")]

    public string FuncionarioId {get; set;}   

     public FolhaPagamento(int valor, int quantidade, int mes, string funcionarioId){
        FolhaId = Guid.NewGuid().ToString();
        Valor = valor;
        Quantidade = quantidade;
        Mes = mes;
        FuncionarioId = funcionarioId;
        SalarioBruto = (valor * quantidade);
        ImpostoIrrf = (SalarioBruto - CalcularIrrf(SalarioBruto)); 
        ImpostoInss = (SalarioBruto - CalcularInss(SalarioBruto));
        ImpostoFgts = (SalarioBruto - (SalarioBruto * ((1 - 8) / 100)));
        SalarioLiquido = (SalarioBruto - (ImpostoIrrf + ImpostoInss));
    }

    public double CalcularIrrf(double salario){
        if(salario > 1903.98 && salario <= 2826.65){
            return (salario * ((1 - 7.5) / 100));
        }else if(salario > 2826.65 && salario <= 3751.05){
            return (salario * ((1 - 15) / 100));
        }else if(salario > 3751.05 && salario <= 4664.68){
            return (salario * ((1 - 22.5) / 100));
        }else if(salario > 4664.68){
            return (salario * ((1 - 27.5) / 100));
        }else{
            return salario;
        }

    }

    public double CalcularInss(double salario){


      if(salario >= 1693.73 && salario <= 2822.90){
            return (salario * ((1 - 9) / 100));
        }
        else if(salario >= 2822.91 && salario <= 5645.80){
            return (salario * ((1 - 11) / 100));
        }else if(salario >= 5645.81){
            return (salario - (1 - 621.03));
        }else{
            return (salario * ((1 - 8) / 100));

        }
    }
}