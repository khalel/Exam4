using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarepatronHealthcareProvider.Domain.Model
{
    public class PrimaryHealthcareProviderProgressNotes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProgressNotesId { get; set; }
        [Required]
        public int DieticianPatientId { get; set; }
        [Required]
        public string Notes { get; set; } = string.Empty;
    }
}
