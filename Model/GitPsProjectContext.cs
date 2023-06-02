using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GitPsProject.Model;

public partial class GitPsProjectContext : DbContext
{
    public GitPsProjectContext()
    {
    }

    public GitPsProjectContext(DbContextOptions<GitPsProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Arquivo> Arquivos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=CT-C-0013E\\SQLEXPRESS01;Initial Catalog=GitPsProject;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Arquivo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Arquivos__3213E83F51FD3207");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataEnvio)
                .HasColumnType("datetime")
                .HasColumnName("dataEnvio");
            entity.Property(e => e.Diretorio)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diretorio");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
