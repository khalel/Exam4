using CarepatronHealthcareProvider.Domain.Model;

namespace CarepatronHealthcareProvider.Domain.Repository
{
    public interface ICompany1PatientRepository : IGenericRepository<Company1Patient>
    {
        Company1Patient? GetPatientDocuments(string patientHealthcareProviderNumber);
    }
}
