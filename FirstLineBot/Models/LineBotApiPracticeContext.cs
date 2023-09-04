using Microsoft.EntityFrameworkCore;

namespace FirstLineBot.Models;

public partial class LineBotApiPracticeContext : DbContext
{
    public LineBotApiPracticeContext()
    {
    }

    public LineBotApiPracticeContext(DbContextOptions<LineBotApiPracticeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Linebot> Linebots { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Linebot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("linebot");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Major)
                .HasMaxLength(20)
                .HasColumnName("major");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
