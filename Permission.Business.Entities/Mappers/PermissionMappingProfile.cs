using AutoMapper;
using Permission.Business.Entities.DTO;

namespace Permission.Business.Entities.Mappers
{
    public class PermissionMappingProfile : Profile
    {
        public PermissionMappingProfile()
        {
            CreateMap<Permissions.Permission, PermissionView>()
                .ForMember(x => x.PermissionTypeName, y => y.MapFrom(s => s.PermissionTypes.Description))
                .ForMember(x => x.Name, y => y.MapFrom(s => s.Employees.Name))
                .ForMember(x => x.LastName, y => y.MapFrom(s => s.Employees.LastName)).ReverseMap();
        }
    }
}
