using Microsoft.EntityFrameworkCore;
using Todo.Domain.Handlers;
using Todo.Domain.Infra.Contexts;
using Todo.Domain.Infra.Repositories;
using Todo.Domain.Repositories;

namespace Todo.Domain.Api;

public static class Startup
{
    public static void AddDatabases(this IServiceCollection services, string? connectionString)
    {
        services.AddDbContext<DataContext>(_ => _.UseInMemoryDatabase("Database"));

        services.AddTransient<ITodoRepository, TodoRepository>();
        services.AddTransient<TodoHandler, TodoHandler>();
    }

    public static void AddServices(this IServiceCollection services)
    {
        services.AddRazorPages(); // Add support for Razor Pages
    }

    public static void AddApplication(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseRouting();
        app.UseCors(x =>
            x.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.Run();
    }
}