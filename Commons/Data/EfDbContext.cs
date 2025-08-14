using System.Data.Common;
using Commons.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Commons.Data;

public partial class EfDbContext : DbContext
{
    public EfDbContext(DbContextOptions<EfDbContext> options)
        : base(options)
    {
    }

    public DbSet<Cartao> Cartoes { get; set; }
    public DbSet<Cliente> Clientes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
