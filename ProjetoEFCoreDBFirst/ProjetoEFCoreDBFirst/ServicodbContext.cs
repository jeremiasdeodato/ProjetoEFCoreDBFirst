using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjetoEFCoreDBFirst
{
    public partial class ServicodbContext : DbContext
    {
        public ServicodbContext()
        {
        }

        public ServicodbContext(DbContextOptions<ServicodbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Analistasuporte> Analistasuporte { get; set; }
        public virtual DbSet<Ordemdetrabalho> Ordemdetrabalho { get; set; }
        public virtual DbSet<Requisicao> Requisicao { get; set; }
        public virtual DbSet<Statusordemtrabalho> Statusordemtrabalho { get; set; }
        public virtual DbSet<Statusrequisicao> Statusrequisicao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=JeraMour@21;database=servicodb", x => x.ServerVersion("8.0.27-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Analistasuporte>(entity =>
            {
                entity.ToTable("analistasuporte");

                entity.Property(e => e.AnalistaSuporteId).HasColumnName("analistaSuporteId");

                entity.Property(e => e.AnalistaAtivo)
                    .HasColumnName("analistaAtivo")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Ramal)
                    .HasColumnName("ramal")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Ordemdetrabalho>(entity =>
            {
                entity.HasKey(e => new { e.RequisicaoId, e.OrdemTrabalhoId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("ordemdetrabalho");

                entity.HasIndex(e => e.AnalistaSuporteId)
                    .HasName("ordemdetrabalho_FK_2");

                entity.HasIndex(e => e.StatusOrdemTrabalhoId)
                    .HasName("ordemdetrabalho_FK_1");

                entity.Property(e => e.RequisicaoId).HasColumnName("requisicaoId");

                entity.Property(e => e.OrdemTrabalhoId).HasColumnName("ordemTrabalhoId");

                entity.Property(e => e.AnalistaSuporteId).HasColumnName("analistaSuporteId");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnName("dataAtualizacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.StatusOrdemTrabalhoId).HasColumnName("statusOrdemTrabalhoId");

                entity.HasOne(d => d.AnalistaSuporte)
                    .WithMany(p => p.Ordemdetrabalho)
                    .HasForeignKey(d => d.AnalistaSuporteId)
                    .HasConstraintName("ordemdetrabalho_FK_2");

                entity.HasOne(d => d.Requisicao)
                    .WithMany(p => p.Ordemdetrabalho)
                    .HasForeignKey(d => d.RequisicaoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ordemdetrabalho_FK");

                entity.HasOne(d => d.StatusOrdemTrabalho)
                    .WithMany(p => p.Ordemdetrabalho)
                    .HasForeignKey(d => d.StatusOrdemTrabalhoId)
                    .HasConstraintName("ordemdetrabalho_FK_1");
            });

            modelBuilder.Entity<Requisicao>(entity =>
            {
                entity.ToTable("requisicao");

                entity.HasIndex(e => e.StatusId)
                    .HasName("requisicao_FK");

                entity.Property(e => e.RequisicaoId).HasColumnName("requisicaoId");

                entity.Property(e => e.DataAbertura)
                    .HasColumnName("dataAbertura")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFechamento)
                    .HasColumnName("dataFechamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAtualizacao)
                    .HasColumnName("dataUltimaAtualizacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.StatusId).HasColumnName("statusId");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Requisicao)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("requisicao_FK");
            });

            modelBuilder.Entity<Statusordemtrabalho>(entity =>
            {
                entity.ToTable("statusordemtrabalho");

                entity.Property(e => e.StatusOrdemTrabalhoId).HasColumnName("statusOrdemTrabalhoId");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Statusrequisicao>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PRIMARY");

                entity.ToTable("statusrequisicao");

                entity.Property(e => e.StatusId).HasColumnName("statusId");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
