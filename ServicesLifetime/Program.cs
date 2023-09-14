using DependencyInjectionLifetimeSample.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<PrimaryService>();
builder.Services.AddScoped<SecondaryService>();
builder.Services.AddTransient<TertiaryService>();

var descriptor = new ServiceDescriptor(
    typeof(SecondaryService),
    typeof(PrimaryService),
    ServiceLifetime.Transient);
builder.Services.TryAddEnumerable(descriptor);

var app = builder.Build();

app.MapGet("/", (IEnumerable<IService> services) => Results.Ok(services.Select(x=>x.GetType().Name)));

app.Run();

public interface IService
{
    
}