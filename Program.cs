using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NicollasDavi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/funcionario/cadastrar", ([FromBody] Funcionario funcionario, [FromServices] AppDbContext context) => {

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

app.Run();
