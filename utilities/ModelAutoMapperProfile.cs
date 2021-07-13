using AutoMapper;
using HealthyAPI.DTOS;
using HealthyAPI.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.utilities
{
    public class ModelAutoMapperProfile:Profile
    {
        public ModelAutoMapperProfile()
        {
            CreateMap<MoneyPlacement, MoneyPlacementDto>().ReverseMap();

            CreateMap<MoneyTaker, MoneyTakerDto>().ReverseMap();
        }
    }
}
