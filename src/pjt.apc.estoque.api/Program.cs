using Microsoft.EntityFrameworkCore;
using pjt.apc.estoque.api.Context;
using pjt.apc.estoque.api.Dependencies;
using pjt.apc.estoque.domain.Bogus;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProdutoContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DbCon")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDependencyInjectionConfiguration();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<FakeDataProduto>();

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