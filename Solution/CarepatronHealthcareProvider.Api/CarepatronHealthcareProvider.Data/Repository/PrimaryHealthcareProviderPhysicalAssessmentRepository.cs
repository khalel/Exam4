using CarepatronHealthcareProvider.Domain;
using CarepatronHealthcareProvider.Domain.Model;
using CarepatronHealthcareProvider.Domain.Repository;

namespace CarepatronHealthcareProvider.Data.Repository
{
    public class PrimaryHealthcareProviderPhysicalAssessmentRepository : GenericRepository<PrimaryHealthcareProviderPhysicalAssessment>, IPrimaryHealthcareProviderPhysicalAssessmentRepository
    {
        public PrimaryHealthcareProviderPhysicalAssessmentRepository(DataContext context) : base(context)
        {
        }

        public PrimaryHealthcareProviderPhysicalAssessment Create(PrimaryHealthcareProviderPhysicalAssessment assessment)
        {
            _context.Add(assessment);
            _context.SaveChanges();

            return assessment;
        }
    }
}
