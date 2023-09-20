using Todo.Domain.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServices();
builder.Services.AddDatabases(builder.Configuration.GetConnectionString("DefaultConnection"));


var app = builder.Build();
app.AddApplication();
// Configure the HTTP request pipeline.
