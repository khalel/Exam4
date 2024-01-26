using CarepatronHealthcareProvider.Domain;
using CarepatronHealthcareProvider.Domain.Model;
using CarepatronHealthcareProvider.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace CarepatronHealthcareProvider.Data.Repository
{
    public class Company2PatientRepository : GenericRepository<Company2Patient>, ICompany2PatientRepository
    {
        public Company2PatientRepository(DataContext context) : base(context)
        {
        }

        public Company2Patient? GetPatientDocuments(string patientHealthcareProviderNumber)
        {
            return _context.Company2Patient?
                .Where(q => q.RecordNumber.Equals(patientHealthcareProviderNumber))
                .Include(i => i.Company2PhysicalAssessment)
                .Include(i => i.Company2ProgressNotes)
                .SingleOrDefault();
        }

    }
}
