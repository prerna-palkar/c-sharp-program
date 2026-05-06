class AppDb : DbContext
{
    public DbSet<User> Users { get; set; }
}
