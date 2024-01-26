using AutoMapper;
using CarepatronHealthcareProvider.Contract.Request;
using CarepatronHealthcareProvider.Domain.Model;

namespace CarepatronHealthcareProvider.Domain.Service
{
    public class DieticianPatientService : IDieticianPatientService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DieticianPatientService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public object GetPatientDocuments(int id)
        {
            return _unitOfWork.DieticianPatients.GetPatient(id) ?? new Model.DieticianPatient();
        }

        public DieticianPatient CreatePatient(CreatePatientRequest dieticianPatientRequest)
        {
            //TODO: Error: 
            //var mapped = _mapper.Map<DieticianPatient>(dieticianPatientRequest);

            DieticianPatient dieticianPatient = new DieticianPatient()
            {
                FirstName = dieticianPatientRequest.FirstName,
                LastName = dieticianPatientRequest.LastName,
                Email = dieticianPatientRequest.Email,
                Address = dieticianPatientRequest.Address,
                HealthcareProviderNumber = dieticianPatientRequest.HealthcareProviderNumber,
                HealthcareProviderId = dieticianPatientRequest.HealthcareProviderId,
            };

            var response = _unitOfWork.DieticianPatients.CreatePatient(dieticianPatient);

            // TODO: Change this logic with actual fetching of data from other microservices
            var carepatronPatient = new Patient();
            //var company1Patient = new Company1Patient();
            //var company2Patient = new Company2Patient();
            if (dieticianPatient.HealthcareProviderId == 1)
            {
                carepatronPatient = _unitOfWork.Patients.GetPatientDocuments(dieticianPatient.HealthcareProviderNumber) ?? new Patient();
                //TODO: Use mapper, having issues with automapper
                foreach (var assessments in carepatronPatient.PhysicalAssessments)
                {
                    _unitOfWork.PrimaryHealthcareProviderPhysicalAssessment.Create(
                        new PrimaryHealthcareProviderPhysicalAssessment()
                        {
                            DieticianPatientId = carepatronPatient.PatientId,
                            Assessment = assessments.Assessment
                        });
                }
                //TODO: Add syncing of Notes
            }
            else if (dieticianPatient.HealthcareProviderId == 2)
            {
                // TODO: Add logic to sync records from company 1
                //company1Patient = _unitOfWork.Company1Patients.GetPatientDocuments(dieticianPatient.HealthcareProviderNumber) ?? new Company1Patient();
            }
            else if (dieticianPatient.HealthcareProviderId == 3)
            {
                // TODO: Add logic to sync records from company 1
                //company2Patient = _unitOfWork.Company2Patients.GetPatientDocuments(dieticianPatient.HealthcareProviderNumber) ?? new Company2Patient();
            }

            return _unitOfWork.DieticianPatients.GetPatient(response.DieticianPatientId) ?? new Model.DieticianPatient();
        }
    }
}
