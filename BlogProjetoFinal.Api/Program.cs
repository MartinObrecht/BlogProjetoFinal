using BlogProjetoFinal.Api.Application.Handlers.Artigos.CriaArtigo;
using BlogProjetoFinal.Api.Application.Handlers.Usuarios.ConsultaUsuario;
using BlogProjetoFinal.Api.Application.Handlers.Usuarios.ConsultaUsuarios;
using BlogProjetoFinal.Api.Application.Handlers.Usuarios.CriaUsuario;
using BlogProjetoFinal.Api.Data;
using BlogProjetoFinal.Api.Data.Repositories.Db;
using BlogProjetoFinal.Api.Domain.Repositories;
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
builder.Services.AddScoped<IRequestHandler<ConsultaUsuarioRequest, ConsultaUsuarioResponse>, ConsultaUsuarioHandler>();
builder.Services.AddScoped<IRequestHandler<ConsultaUsuariosRequest, List<ConsultaUsuariosResponse>>, ConsultaUsuariosHandler>();
builder.Services.AddScoped<IRequestHandler<CriaUsuarioRequest, CriaUsuarioResponse>, CriaUsuarioHandler>();
builder.Services.AddScoped<IRequestHandler<CriaArtigoRequest, CriaArtigoResponse>, CriaArtigoHandler>();

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IArtigoRepository, ArtigoRepository>();

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
