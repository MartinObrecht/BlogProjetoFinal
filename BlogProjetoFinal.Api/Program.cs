using BlogProjetoFinal.Application.Handlers.Usuario.ConsultaUsuario;
using BlogProjetoFinal.Data;
using BlogProjetoFinal.Data.Repositories.Db;
using BlogProjetoFinal.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connerctionString = builder.Configuration.GetConnectionString("BlogProjetoFinalDbContext");

builder.Services.AddDbContext<BlogProjetoFinalDbContext>(options => options.UseSqlServer(connerctionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddTransient<IRequestHandler<ConsultaUsuarioRequest, ConsultaUsuarioResponse>, ConsultaUsuarioHandler>();

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
