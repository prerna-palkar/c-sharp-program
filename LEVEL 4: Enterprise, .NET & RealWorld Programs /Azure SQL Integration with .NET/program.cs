using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("AzureSQL")));

var app = builder.Build();

app.MapGet("/students", async (AppDbContext db) =>
{
    return await db.Students.ToListAsync();
});

app.Run();

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students => Set<Student>();
}

public class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = "";
}
