using Microsoft.EntityFrameworkCore;
using pjt.apc.estoque.api.Context;
using pjt.apc.estoque.application.Dispatcher;
using pjt.apc.estoque.domain.Interfaces;
//using pjt.apc.estoque.infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProdutoContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DbCon")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddRegisters();




//services.AddDependencyInjectionConfiguration();

/*
builder.Services.AddSingleton<IProdutoDispatcher, ProdutoDispatcher>();
builder.Services.AddSingleton<IProdutoRepository, ProdutoRepository>();*/

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();