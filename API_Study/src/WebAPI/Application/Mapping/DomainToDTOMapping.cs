using AutoMapper;
using WebAPI.Domain.DTOs;
using WebAPI.Domain.Model.EmployeeAgregate;

namespace WebAPI.Application.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping()
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.NameEmployee, a => a.MapFrom(orig => orig.name));
        }        
    }
}