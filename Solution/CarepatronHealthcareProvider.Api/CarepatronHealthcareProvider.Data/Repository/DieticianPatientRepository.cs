using CarepatronHealthcareProvider.Domain;
using CarepatronHealthcareProvider.Domain.Model;
using CarepatronHealthcareProvider.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace CarepatronHealthcareProvider.Data.Repository
{
    public class DieticianPatientRepository : GenericRepository<DieticianPatient>, IDieticianPatientRepository
    {
        public DieticianPatientRepository(DataContext context) : base(context)
        {
        }

        public DieticianPatient? GetPatient(int id)
        {
            return _context.DieticianPatient?
                .Where(q => q.DieticianPatientId.Equals(id))
                .Include(i => i.HealthcareProvider)
                .Include(i => i.PrimaryHealthcareProviderPhysicalAssessments)
                .Include(i => i.PrimaryHealthcareProviderProgressNotes)
                .SingleOrDefault();
        }

        public DieticianPatient CreatePatient(DieticianPatient dieticianPatient)
        {
            _context.Add(dieticianPatient);
            _context.SaveChanges();

            //return GetPatient(dieticianPatient.DieticianPatientId) ?? dieticianPatient;
            return dieticianPatient;
        }

    }
}
