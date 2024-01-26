using CarepatronHealthcareProvider.Domain;
using CarepatronHealthcareProvider.Domain.Model;
using CarepatronHealthcareProvider.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace CarepatronHealthcareProvider.Data.Repository
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(DataContext context) : base(context)
        {
        }

        public Patient? GetPatientDocuments(string patientHealthcareProviderNumber)
        {
            return _context.Patient?
                .Where(q => q.RecordNumber.Equals(patientHealthcareProviderNumber))
                .Include(i => i.PhysicalAssessments)
                .Include(i => i.ProgressNotes)
                .SingleOrDefault();
        }

    }
}
