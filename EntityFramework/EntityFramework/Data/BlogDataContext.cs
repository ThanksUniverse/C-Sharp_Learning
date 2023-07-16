using EntityFramework.Data.Mappings;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data;

public class BlogDataContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<PostWithTagsCount> PostWithTagsCounts { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost,1433;Database=EntityF2;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryMap());
        modelBuilder.ApplyConfiguration(new UserMap());
        modelBuilder.ApplyConfiguration(new PostMap());

        modelBuilder.Entity<PostWithTagsCount>(x =>
        {
            x.ToSqlQuery(@"
                    Select
                        [Title] as [Name],
                        Count([Id]) as Count
                    from 
                        Posts
                    where 
                        [PostId] = [Id]
                ");
        });
    }
}