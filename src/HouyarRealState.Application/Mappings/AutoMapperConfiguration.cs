using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using HouyarRealState.Application.DTOs.Common;
using HouyarRealState.Application.DTOs.Settings;
using HouyarRealState.Domain.Entities.Settings;

namespace HouyarRealState.Application.Mappings
{
    public class AutoMapperConfiguration : Profile
    {

        public AutoMapperConfiguration()
        {
            CreateMap<Language, LanguageDTO>().ReverseMap();

        }


    }
}
