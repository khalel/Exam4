using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarepatronHealthcareProvider.Domain.Model
{
    public class Company2ProgressNotes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProgressNotesId { get; set; }
        [Required]
        public int Company2PatientId { get; set; }
        [Required]
        public string Notes { get; set; } = string.Empty;
    }
}
