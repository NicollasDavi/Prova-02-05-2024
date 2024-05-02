using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NicollasDavi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
var app = builder.Build();

app.MapGet("/api/funcionario/listar", ([FromServices] AppDbContext context) =>
{
    if (context.Funcionario.Any())
    {
        return Results.Ok(context.Funcionario.ToList());
    }
    return Results.NotFound("Não existem funcionarios");
});

app.MapPost("/api/funcionario/cadastrar", ([FromBody] Funcionario funcionario, [FromServices] AppDbContext context) =>
{

    try
    {
        context.Funcionario.Add(funcionario);
        context.SaveChanges();
        return Results.Created("", funcionario);
    }
    catch (Exception)
    {

        return Results.BadRequest("Erro ao criar Funcoinario");
    }
});


app.MapGet("/api/folha/listar", ([FromServices] AppDbContext context) =>
{
    if (context.FolhaPagamento.Any())
    {
        return Results.Ok(context.FolhaPagamento.ToList());
    }
    return Results.NotFound("Não existem funcionarios");
});

app.MapPost("/api/folha/cadastrar", ([FromBody] FolhaPagamento folha, [FromServices] AppDbContext context) =>
{
    try
    {
        context.FolhaPagamento.Add(folha);
        context.SaveChanges();
        return Results.Created("", folha);
    }
    catch (Exception)
    {

        return Results.BadRequest("Erro ao criar Funcoinario");
    }
});

app.MapGet("/folha/buscar/{cpf}/{mes}/{ano}", ([FromRoute] string cpf, [FromRoute] int mes, [FromRoute] int ano ,[FromServices] AppDbContext context) =>
{
   Funcionario? funcionario = context.Funcionario.FirstOrDefault(x => x.Cpf == cpf);
   return funcionario;

});

app.Run();
