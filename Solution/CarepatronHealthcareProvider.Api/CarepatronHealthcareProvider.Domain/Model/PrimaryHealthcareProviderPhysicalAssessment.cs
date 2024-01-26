using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarepatronHealthcareProvider.Domain.Model
{
    public class PrimaryHealthcareProviderPhysicalAssessment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhysicalAssessmentId { get; set; }
        [Required]
        public int DieticianPatientId { get; set; }
        [Required]
        public string Assessment { get; set; } = string.Empty;
    }
}
