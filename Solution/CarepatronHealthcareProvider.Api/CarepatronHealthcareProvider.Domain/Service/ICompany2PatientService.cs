namespace CarepatronHealthcareProvider.Domain.Service
{
    public interface ICompany2PatientService
    {
        object GetPatientDocuments(string patientHealthcareProviderNumber);
    }
}
