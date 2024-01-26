using System.ComponentModel.DataAnnotations;

namespace CarepatronHealthcareProvider.Domain.Model
{
    public class Company2Patient
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

        public ICollection<Company2PhysicalAssessment> Company2PhysicalAssessment { get; set; }
        public ICollection<Company2ProgressNotes> Company2ProgressNotes { get; set; }
    }
}
