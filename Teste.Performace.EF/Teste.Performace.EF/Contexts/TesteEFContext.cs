using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Teste.Performace.EF.Domains;

#nullable disable

namespace Teste.Performace.EF.Contexts
{
    public partial class TesteEFContext : DbContext
    {
        public TesteEFContext()
        {
        }

        public TesteEFContext(DbContextOptions<TesteEFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=db_testes; Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.Senha)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SENHA");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
