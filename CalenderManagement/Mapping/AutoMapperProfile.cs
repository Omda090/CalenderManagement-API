using AutoMapper;
using CalenderManagement.DTOs;
using CalenderManagement.Models;

namespace CalenderManagement.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {


            CreateMap<AdminForm, AdminFormDto>();
            CreateMap<AdminFormDto, AdminForm>();



        }
    }
}
