using System;
using System.Collections.Generic;
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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;database=line_bot_api_practice;uid=root;pwd=chak771477012", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.1.0-mysql"));

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
