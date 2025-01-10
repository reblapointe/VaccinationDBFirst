using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VaccinationDBFirst.Modeles;

public partial class VaccinationDefiContext : DbContext
{
    public VaccinationDefiContext()
    {
    }

    public VaccinationDefiContext(DbContextOptions<VaccinationDefiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Immunisation> Immunisations { get; set; }

    public virtual DbSet<Vaccin> Vaccins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=VaccinationDefi;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Immunisation>(entity =>
        {
            entity.HasIndex(e => e.VaccinId, "IX_Immunisations_VaccinId");

            entity.Property(e => e.Discriminator).HasMaxLength(13);
            entity.Property(e => e.Nampatient).HasColumnName("NAMPatient");

            entity.HasOne(d => d.Vaccin).WithMany(p => p.Immunisations).HasForeignKey(d => d.VaccinId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
