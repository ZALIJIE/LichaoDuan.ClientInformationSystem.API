using LichaoDuan.ClientInformationSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LichaoDuan.ClientInformationSystem.Infrastrcture.Data
{
    public class ClientInformationSystemDbContext:DbContext
    {

        public ClientInformationSystemDbContext(DbContextOptions<ClientInformationSystemDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(ConfigureClient);
            modelBuilder.Entity<Employee>(ConfigureEmployee);
            modelBuilder.Entity<Interaction>(ConfigureInteraction);
        }

        public void ConfigureClient(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Email).HasMaxLength(50);
            builder.Property(c => c.Phones).HasMaxLength(30);
            builder.Property(c => c.Address).HasMaxLength(100);
            builder.Property(c => c.AddedOn);
        }

        public void ConfigureEmployee(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(e => e.Id);
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Password).HasMaxLength(10);
            builder.Property(c => c.Designation).HasMaxLength(50);
        }

        public void ConfigureInteraction(EntityTypeBuilder<Interaction> builder)
        {
            builder.ToTable("Interactions");
            builder.HasKey(i => i.Id);
            builder.HasOne(i => i.Employee)
                .WithMany(e => e.Interaction)
                .HasForeignKey(i => i.EmployeeId);
            builder.HasOne(i => i.Client)
                .WithMany(e => e.Interaction)
                .HasForeignKey(i => i.ClientId);
            builder.Property(i => i.IntType).HasMaxLength(1);
            builder.Property(i => i.IntDate);
            builder.Property(i => i.Remarks).HasMaxLength(500);
        }


        public DbSet<Client> Clients { get; set; }
        public DbSet<Interaction> Interactions { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
