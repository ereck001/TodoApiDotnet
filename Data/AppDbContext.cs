using Todo.Models;
using Microsoft.EntityFrameworkCore;

namespace Todo.Data{
    public class AppDbContext : DbContext
    {
        public DbSet<TodoModel> Todos { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder option)
            => option.UseSqlServer(
                "Server=localhost,1433;Database=app.db;User ID=sa;Password=<YourStrong@Passw0rd>;TrustServerCertificate=True"
                );
    }
}