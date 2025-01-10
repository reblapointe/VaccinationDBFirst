using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VaccinationDBFirst.Modeles;

public partial class VaccinationContext : DbContext
{
    public VaccinationContext()
    {
    }

    public VaccinationContext(DbContextOptions<VaccinationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dose> Doses { get; set; }

    public virtual DbSet<Vaccin> Vaccins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Vaccination;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dose>(entity =>
        {
            entity.HasIndex(e => e.VaccinId, "IX_Doses_VaccinId");

            entity.Property(e => e.Nampatient).HasColumnName("NAMPatient");

            entity.HasOne(d => d.Vaccin).WithMany(p => p.Doses).HasForeignKey(d => d.VaccinId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
