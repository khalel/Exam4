using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarepatronHealthcareProvider.Domain.Model
{
    public class Company1ProgressNotes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProgressNotesId { get; set; }
        [Required]
        public int Company1PatientId { get; set; }
        [Required]
        public string Notes { get; set; } = string.Empty;
    }
}
