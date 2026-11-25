using AutoMapper;
using HouyarRealState.Application.DTOs.Properties;
using HouyarRealState.Application.DTOs.Settings;
using HouyarRealState.Application.Helpers;
using HouyarRealState.Domain.Entities.Properties;

namespace HouyarRealState.Application.Mappings
{
    public class AutoMapperConfiguration : Profile
    {

        public AutoMapperConfiguration()
        {

            CreateMap<Property, PropertyDTO>().ReverseMap();
            CreateMap<Property, AddPropertyDTO>().ReverseMap();
            CreateMap<Property, UpdatePropertyDTO>().ReverseMap();

            //CreateMap<PropertyDTO, Property>()
            //    .ForMember(x => x.CreateDate, s => s.MapFrom(d => d.CreateDate.ToMiladi()))
            //    .ForMember(x => x.ModifyDate, s => s.MapFrom(d => d.ModifyDate.ToMiladi()));

            //CreateMap<Property, PropertyDTO>()
            //    .ForMember(x => x.CreateDate, s => s.MapFrom(d => d.CreateDate.ToShamsi()))
            //    .ForMember(x => x.ModifyDate, s => s.MapFrom(d => d.ModifyDate.ToShamsi()));

        }


    }
}
