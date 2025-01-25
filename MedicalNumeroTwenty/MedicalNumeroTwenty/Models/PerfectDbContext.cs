using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace MedicalNumeroTwenty.Models;

public partial class PerfectDbContext : DbContext
{
    public PerfectDbContext()
    {
    }

    public PerfectDbContext(DbContextOptions<PerfectDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Action> Actions { get; set; }

    public virtual DbSet<ActionLaborantLink> ActionLaborantLinks { get; set; }

    public virtual DbSet<Administrator> Administrators { get; set; }

    public virtual DbSet<AfraidCompany> AfraidCompanies { get; set; }

    public virtual DbSet<Analisator> Analisators { get; set; }

    public virtual DbSet<Buhgalter> Buhgalters { get; set; }

    public virtual DbSet<Laborant> Laborants { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=127.0.0.1;database=PerfectDb;user=root;pwd=12345", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.5.23-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Action>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Action");

            entity.HasIndex(e => e.Orderid, "fk_Action_1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(45)
                .HasColumnName("code");
            entity.Property(e => e.Datedebt)
                .HasColumnType("datetime")
                .HasColumnName("datedebt");
            entity.Property(e => e.Middledrift)
                .HasMaxLength(45)
                .HasColumnName("middledrift");
            entity.Property(e => e.Name)
                .HasMaxLength(75)
                .HasColumnName("name");
            entity.Property(e => e.Orderid)
                .HasColumnType("int(11)")
                .HasColumnName("orderid");
            entity.Property(e => e.Orderstatus)
                .HasMaxLength(45)
                .HasColumnName("orderstatus");
            entity.Property(e => e.Price)
                .HasColumnType("int(11)")
                .HasColumnName("price");

            entity.HasOne(d => d.Order).WithMany(p => p.Actions)
                .HasForeignKey(d => d.Orderid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Action_1");
        });

        modelBuilder.Entity<ActionLaborantLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ActionLaborantLink");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Actionid)
                .HasColumnType("int(11)")
                .HasColumnName("actionid");
            entity.Property(e => e.Laborantid)
                .HasColumnType("int(11)")
                .HasColumnName("laborantid");
        });

        modelBuilder.Entity<Administrator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Administrator");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Login)
                .HasMaxLength(45)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
        });

        modelBuilder.Entity<AfraidCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("AfraidCompany");

            entity.HasIndex(e => e.Buhgalterid, "fk_AfraidCompany_1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(45)
                .HasColumnName("address");
            entity.Property(e => e.Bik)
                .HasMaxLength(45)
                .HasColumnName("bik");
            entity.Property(e => e.Buhgalterid)
                .HasColumnType("int(11)")
                .HasColumnName("buhgalterid");
            entity.Property(e => e.Inn)
                .HasMaxLength(45)
                .HasColumnName("inn");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Rs)
                .HasMaxLength(45)
                .HasColumnName("rs");

            entity.HasOne(d => d.Buhgalter).WithMany(p => p.AfraidCompanies)
                .HasForeignKey(d => d.Buhgalterid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_AfraidCompany_1");
        });

        modelBuilder.Entity<Analisator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Analisator");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Orderdate)
                .HasColumnType("datetime")
                .HasColumnName("orderdate");
            entity.Property(e => e.WorkSeconds)
                .HasColumnType("int(11)")
                .HasColumnName("workSeconds");
            entity.Property(e => e.Workdate)
                .HasColumnType("datetime")
                .HasColumnName("workdate");
        });

        modelBuilder.Entity<Buhgalter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Buhgalter");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Login)
                .HasMaxLength(45)
                .HasColumnName("login");
            entity.Property(e => e.Logindate)
                .HasColumnType("datetime")
                .HasColumnName("logindate");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Laborant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Laborant");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Login)
                .HasMaxLength(45)
                .HasColumnName("login");
            entity.Property(e => e.Logindate)
                .HasColumnType("datetime")
                .HasColumnName("logindate");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(45)
                .HasColumnName("patronymic");
            entity.Property(e => e.Surname)
                .HasMaxLength(45)
                .HasColumnName("surname");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Order");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Orderdays)
                .HasColumnType("int(5)")
                .HasColumnName("orderdays");
            entity.Property(e => e.Status)
                .HasMaxLength(45)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Patient");

            entity.HasIndex(e => e.Afraidcompanyid, "fk_Patient_1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Afraidcompanyid)
                .HasColumnType("int(11)")
                .HasColumnName("afraidcompanyid");
            entity.Property(e => e.Birth)
                .HasColumnType("datetime")
                .HasColumnName("birth");
            entity.Property(e => e.Login)
                .HasMaxLength(45)
                .HasColumnName("login");
            entity.Property(e => e.Mail)
                .HasMaxLength(45)
                .HasColumnName("mail");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Passportcode)
                .HasColumnType("int(6)")
                .HasColumnName("passportcode");
            entity.Property(e => e.Passportserial)
                .HasColumnType("int(6)")
                .HasColumnName("passportserial");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(45)
                .HasColumnName("patronymic");
            entity.Property(e => e.Phone)
                .HasMaxLength(45)
                .HasColumnName("phone");
            entity.Property(e => e.Polyscode)
                .HasColumnType("int(45)")
                .HasColumnName("polyscode");
            entity.Property(e => e.Polystype)
                .HasMaxLength(45)
                .HasColumnName("polystype");
            entity.Property(e => e.Surname)
                .HasMaxLength(45)
                .HasColumnName("surname");

            entity.HasOne(d => d.Afraidcompany).WithMany(p => p.Patients)
                .HasForeignKey(d => d.Afraidcompanyid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Patient_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
