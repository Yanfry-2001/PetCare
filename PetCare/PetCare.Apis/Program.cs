using Microsoft.EntityFrameworkCore;
using PetCare.Apis.Data;

var builder = WebApplication.CreateBuilder(args);

// Configura el DbContext con SQL Server
builder.Services.AddDbContext<PetDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Agrega los controladores
builder.Services.AddControllers();

// Swagger para pruebas
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware de desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
