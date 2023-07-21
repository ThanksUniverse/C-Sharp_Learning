using Todo.Controllers;
using Todo.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(); // Dessa forma o ASP.NET Gerencia a conexao para nos

var app = builder.Build();

app.MapControllers();

app.Run();
