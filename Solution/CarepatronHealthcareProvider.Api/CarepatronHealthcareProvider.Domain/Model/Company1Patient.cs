using System.ComponentModel.DataAnnotations;

namespace CarepatronHealthcareProvider.Domain.Model
{
    public class Company1Patient
    {
        [Key]
        public int Company1PatientId { get; set; }
        [Required]
        [StringLength(60)]
        public string RecordNumber { get; set; } = string.Empty;
        [Required]
        [StringLength(60)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [StringLength(60)]
        public string LastName { get; set; } = string.Empty;

        public ICollection<Company1PhysicalAssessment> Company1PhysicalAssessment { get; set; }
        public ICollection<Company1ProgressNotes> Company1ProgressNotes { get; set; }
    }
}
