using AutoMapper;

namespace CarepatronHealthcareProvider.Domain.Mapper
{
    public class DieticianPatientMapper : Profile
    {
        public DieticianPatientMapper()
        {
            CreateMap<Model.DieticianPatient, Contract.Request.CreatePatientRequest>()
                .ForSourceMember(mem => mem.DieticianPatientId, opt => opt.DoNotValidate())
                .ForSourceMember(mem => mem.HealthcareProvider, opt => opt.DoNotValidate())
                .ForSourceMember(mem => mem.PrimaryHealthcareProviderPhysicalAssessments, opt => opt.DoNotValidate())
                .ForSourceMember(mem => mem.PrimaryHealthcareProviderProgressNotes, opt => opt.DoNotValidate());
        }
    }
}
