using CarepatronHealthcareProvider.Contract.Request;
using CarepatronHealthcareProvider.Domain.Model;

namespace CarepatronHealthcareProvider.Domain.Service
{
    public interface IDieticianPatientService
    {
        object GetPatientDocuments(int id);

        DieticianPatient CreatePatient(CreatePatientRequest dieticianPatientRequest);
    }
}
