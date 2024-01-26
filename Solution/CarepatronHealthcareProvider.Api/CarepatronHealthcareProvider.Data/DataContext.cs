using CarepatronHealthcareProvider.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace CarepatronHealthcareProvider.Domain
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patient { get; set; }
        public DbSet<PhysicalAssessment> PhysicalAssessment { get; set; }
        public DbSet<ProgressNotes> ProgressNotes { get; set; }

        public DbSet<Company1Patient> Company1Patient { get; set; }
        public DbSet<Company1PhysicalAssessment> Company1PhysicalAssessment { get; set; }
        public DbSet<Company1ProgressNotes> Company1ProgressNotes { get; set; }

        public DbSet<Company2Patient> Company2Patient { get; set; }
        public DbSet<Company2PhysicalAssessment> Company2PhysicalAssessment { get; set; }
        public DbSet<Company2ProgressNotes> Company2ProgressNotes { get; set; }

        public DbSet<HealthcareProvider> HealthcareProvider { get; set; }

        public DbSet<DieticianPatient> DieticianPatient { get; set; }
        public DbSet<PrimaryHealthcareProviderPhysicalAssessment> PrimaryHealthcareProviderPhysicalAssessment { get; set; }
        public DbSet<PrimaryHealthcareProviderProgressNotes> PrimaryHealthcareProviderProgressNotes { get; set; }
    }
}
