using Microsoft.EntityFrameworkCore;
using pjt.apc.estoque.api.Context;
using pjt.apc.estoque.api.Dependencies;




//using pjt.apc.estoque.api.Context;
//using pjt.apc.estoque.infrastructure.Repositories;
//using pjt.apc.estoque.domain.Contexts;

//using pjt.apc.estoque.api.Context;
//using pjt.apc.estoque.api.Infra.Repositories;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProdutoContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DbCon")));
//builder.Services.AddDbContext<ProdutoContext>(x => x.UseSqlServer(b => b.MigrationsAssembly("pjt.apc.estoque.api")));


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// DBContexts Config
//services.AddDatabseConfiguration(Configuration);
//builder.Services.AddDatabseConfiguration(IDatabaseConfig databaseConfig);

// Injeção de dependência
//services.AddDependencyInjectionConfiguration();
//builder.Services.AddDependencyInjectionConfiguration();
builder.Services.AddDependencyInjectionConfiguration();


builder.Services.AddSwaggerGen();

//builder.Services.AddDependencyInjectionConfiguration();



//builder.Services.AddScoped<DependencyInjector>();
//builder.Services.AddRegisters(); (NÃO SEI)
//services.AddDependencyInjectionConfiguration(); (NÃO SEI)


//builder.Services.AddScoped<IProdutoDispatcher, ProdutoDispatcher>();
//builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

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