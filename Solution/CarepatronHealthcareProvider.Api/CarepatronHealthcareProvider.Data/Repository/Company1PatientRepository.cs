using CarepatronHealthcareProvider.Domain;
using CarepatronHealthcareProvider.Domain.Model;
using CarepatronHealthcareProvider.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace CarepatronHealthcareProvider.Data.Repository
{
    public class Company1PatientRepository : GenericRepository<Company1Patient>, ICompany1PatientRepository
    {
        public Company1PatientRepository(DataContext context) : base(context)
        {
        }

        public Company1Patient? GetPatientDocuments(string patientHealthcareProviderNumber)
        {
            return _context.Company1Patient?
                .Where(q => q.RecordNumber.Equals(patientHealthcareProviderNumber))
                .Include(i => i.Company1PhysicalAssessment)
                .Include(i => i.Company1ProgressNotes)
                .SingleOrDefault();
        }

    }
}
