using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AngularCoreApi.Models
{
    public partial class PracticeDatabaseContext : DbContext
    {
        public PracticeDatabaseContext()
        {
        }

        public PracticeDatabaseContext(DbContextOptions<PracticeDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public virtual DbSet<EmployeePracForm> EmployeePracForm { get; set; }
        public virtual DbSet<EmployeeSalary> EmployeeSalary { get; set; }

        // Unable to generate entity type for table 'dbo.NewEmloyeeDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.New2EmloyeeDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Employee_Test'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Employee_Test_Audit'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CountryList'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=JUZER\\SQLEXPRESS;initial catalog=PracticeDatabase;trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeDetails>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.Property(e => e.EmpId).ValueGeneratedNever();

                entity.Property(e => e.DateOfJoining).IsRequired();

                entity.Property(e => e.FullName).IsRequired();
            });

            modelBuilder.Entity<EmployeePracForm>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeSalary>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.Property(e => e.EmpId).ValueGeneratedNever();

                entity.Property(e => e.Project)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
