using CarepatronHealthcareProvider.Domain.Repository;

namespace CarepatronHealthcareProvider.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IPatientRepository Patients { get; }
        ICompany1PatientRepository Company1Patients { get; }
        ICompany2PatientRepository Company2Patients { get; }
        IDieticianPatientRepository DieticianPatients { get; }
        IPrimaryHealthcareProviderPhysicalAssessmentRepository PrimaryHealthcareProviderPhysicalAssessment { get; }
        int Complete();
    }
}
