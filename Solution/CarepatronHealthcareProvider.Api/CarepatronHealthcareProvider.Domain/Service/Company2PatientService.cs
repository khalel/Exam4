using AutoMapper;

namespace CarepatronHealthcareProvider.Domain.Service
{
    public class Company2PatientService : ICompany2PatientService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public Company2PatientService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public object GetPatientDocuments(string patientHealthcareProviderNumber)
        {
            return _unitOfWork.Company2Patients.GetPatientDocuments(patientHealthcareProviderNumber) ?? new Model.Company2Patient();
        }
    }
}
