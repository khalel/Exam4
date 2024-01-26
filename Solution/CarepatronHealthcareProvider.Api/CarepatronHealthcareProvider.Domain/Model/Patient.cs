using System.ComponentModel.DataAnnotations;

namespace CarepatronHealthcareProvider.Domain.Model
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Required]
        [StringLength(60)]
        public string RecordNumber { get; set; } = string.Empty;
        [Required]
        [StringLength(60)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [StringLength(60)]
        public string LastName { get; set; } = string.Empty;

        public ICollection<PhysicalAssessment> PhysicalAssessments { get; set; }
        public ICollection<ProgressNotes> ProgressNotes { get; set; }
    }
}
