using CarepatronHealthcareProvider.Domain.Model;

namespace CarepatronHealthcareProvider.Domain.Repository
{
    public interface IPrimaryHealthcareProviderPhysicalAssessmentRepository
    {
        PrimaryHealthcareProviderPhysicalAssessment Create(PrimaryHealthcareProviderPhysicalAssessment assessment);
    }
}
