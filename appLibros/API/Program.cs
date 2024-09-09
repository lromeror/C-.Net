using Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Aqui es donde se crean los servicios
//1. Cadena de conexion
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");//El contenido de mi StringConection
//Ahora se procede a agregar el sercivios en los servicies
builder.Services.AddDbContext<AplicationDbContext>(options=>
options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
