namespace CarepatronHealthcareProvider.Domain.Service
{
    public interface IPatientService
    {
        object GetPatientDocuments(string patientHealthcareProviderNumber);
    }
}
