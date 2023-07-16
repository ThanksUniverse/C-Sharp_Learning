using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data;

public class BlogDataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost,1433;Database=EntityF;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True");
}