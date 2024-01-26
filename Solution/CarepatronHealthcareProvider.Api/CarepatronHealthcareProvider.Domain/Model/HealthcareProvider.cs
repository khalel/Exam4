using System.ComponentModel.DataAnnotations;

namespace CarepatronHealthcareProvider.Domain.Model
{
    public class HealthcareProvider
    {
        [Key]
        public int HealthcareProviderId { get; set; }
        [Required]
        [StringLength(120)]
        public string HealthcareProviderName { get; set; } = string.Empty;
    }
}
