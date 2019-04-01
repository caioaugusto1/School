using AutoMapper;
using School_Project.Entities;
using School_Project.Enums;
using School_Project.Models.Login;

namespace School_Project.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateLoginVM, Login>()
                .ForMember(entity => entity.Id, map => map.MapFrom(vm => vm.Id))
                .ForMember(entity => entity.UserName, map => map.MapFrom(vm => vm.UserName))
                .ForMember(entity => entity.Password, map => map.MapFrom(vm => vm.Password))
                .ReverseMap();

        }
    }
}