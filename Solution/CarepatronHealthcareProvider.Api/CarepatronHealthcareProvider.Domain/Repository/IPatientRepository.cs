using CarepatronHealthcareProvider.Domain.Model;

namespace CarepatronHealthcareProvider.Domain.Repository
{
    public interface IPatientRepository : IGenericRepository<Patient>
    {
        Patient? GetPatientDocuments(string patientHealthcareProviderNumber);
    }
}
