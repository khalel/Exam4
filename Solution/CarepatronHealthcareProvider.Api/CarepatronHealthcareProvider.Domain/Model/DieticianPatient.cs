using System.ComponentModel.DataAnnotations;

namespace CarepatronHealthcareProvider.Domain.Model
{
    public class DieticianPatient
    {
        [Key]
        public int DieticianPatientId { get; set; }
        [Required]
        [StringLength(60)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [StringLength(60)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [StringLength(60)]
        public string Email { get; set; } = string.Empty;
        [Required]
        [StringLength(256)]
        public string Address { get; set; } = string.Empty;
        [StringLength(60)]
        public string HealthcareProviderNumber { get; set; } = string.Empty;

        public int HealthcareProviderId { get; set; }
        public HealthcareProvider HealthcareProvider { get; set; }
        
        public ICollection<PrimaryHealthcareProviderPhysicalAssessment> PrimaryHealthcareProviderPhysicalAssessments { get; set; }
        public ICollection<PrimaryHealthcareProviderProgressNotes> PrimaryHealthcareProviderProgressNotes { get; set; }
    }
}
