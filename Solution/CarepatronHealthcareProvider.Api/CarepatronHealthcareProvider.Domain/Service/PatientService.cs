using AutoMapper;

namespace CarepatronHealthcareProvider.Domain.Service
{
    public class PatientService : IPatientService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PatientService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public object GetPatientDocuments(string patientHealthcareProviderNumber) 
        {
            return _unitOfWork.Patients.GetPatientDocuments(patientHealthcareProviderNumber) ?? new Model.Patient();
        }
    }
}
