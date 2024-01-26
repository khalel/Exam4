using CarepatronHealthcareProvider.Domain.Model;

namespace CarepatronHealthcareProvider.Domain.Repository
{
    public interface ICompany2PatientRepository : IGenericRepository<Company2Patient>
    {
        Company2Patient? GetPatientDocuments(string patientHealthcareProviderNumber);
    }
}
