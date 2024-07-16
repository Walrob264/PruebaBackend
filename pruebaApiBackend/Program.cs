//1. El uso de frameworks
using Microsoft.EntityFrameworkCore;
using pruebaApiBackend.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// 2. Conectar con la base de datos 
const string CONNECTIONNAME = "PruebaDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);


// 3. añadir el contexto 
builder.Services.AddDbContext<PruebaDBContext>(options => options.UseSqlServer(connectionString));


// Añadir los servicios 

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuración de las cors
builder.Services.AddCors(option => {
    option.AddPolicy("Politica", app =>
    {
        app.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Politica");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
