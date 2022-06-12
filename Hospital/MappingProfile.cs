using AutoMapper;
using Hospital.Entities;
using Hospital.Models;

namespace Hospital
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Visit, VisitDto>()
                .ForMember(m => m.DoctorName, c => c.MapFrom(d => d.Doctor.Name))
                .ForMember(m => m.PatientName, c => c.MapFrom(p => p.Patient.Name));
              
        }

    }
}
