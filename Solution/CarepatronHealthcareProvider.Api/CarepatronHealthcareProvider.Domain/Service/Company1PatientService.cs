using AutoMapper;

namespace CarepatronHealthcareProvider.Domain.Service
{
    public class Company1PatientService : ICompany1PatientService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public Company1PatientService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public object GetPatientDocuments(string patientHealthcareProviderNumber)
        {
            return _unitOfWork.Company1Patients.GetPatientDocuments(patientHealthcareProviderNumber) ?? new Model.Company1Patient();
        }
    }
}
