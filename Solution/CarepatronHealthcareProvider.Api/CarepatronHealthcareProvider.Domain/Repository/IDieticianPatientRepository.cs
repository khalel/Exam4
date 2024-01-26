using CarepatronHealthcareProvider.Domain.Model;

namespace CarepatronHealthcareProvider.Domain.Repository
{
    public interface IDieticianPatientRepository : IGenericRepository<DieticianPatient>
    {
        DieticianPatient? GetPatient(int id);

        DieticianPatient CreatePatient(DieticianPatient dieticianPatient);
    }
}
