

using AutoMapper;
using Surface.Entities.DataModels;
using Surface_Entities.DTOs;

namespace Surface_BusinessLayer.Services.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, EmailDTO>();
        }
    }
}
