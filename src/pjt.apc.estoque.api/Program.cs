using Microsoft.EntityFrameworkCore;
//using pjt.apc.estoque.api.Context;
using pjt.apc.estoque.application.Dispatcher;
using pjt.apc.estoque.domain.Interfaces;
//using pjt.apc.estoque.infrastructure.Repositories;
//using pjt.apc.estoque.domain.Contexts;

using pjt.apc.estoque.api.Context;
using pjt.apc.estoque.api.Infra.Repositories;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProdutoContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DbCon")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDatabseConfiguration(IConfiguration configuration);
//builder.Services.AddDependencyInjectionConfiguration();



//builder.Services.AddScoped<DependencyInjector>();
//builder.Services.AddRegisters(); (N�O SEI)
//services.AddDependencyInjectionConfiguration(); (N�O SEI)


builder.Services.AddScoped<IProdutoDispatcher, ProdutoDispatcher>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

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