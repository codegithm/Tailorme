using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.Address;
using TailorMe.Application.DTOs.BottomMeasurement;
using TailorMe.Application.DTOs.Order;
using TailorMe.Application.DTOs.Person;
using TailorMe.Application.DTOs.TopMeasurement;
using TailorMe.Domain.Entites;

namespace TailorMe.Application.Profiles
{
    public class CustomProfiles : Profile
    {
        public CustomProfiles()
        {
            CreateMap<AddressDto, Address>().ReverseMap();
            CreateMap<OrderDto, Order>().ReverseMap();
            CreateMap<PersonDto, Person>().ReverseMap();
            CreateMap<BottomMeasurementDto, BottomMeasurement>().ReverseMap();
            CreateMap<TopMeasurementDto, TopMeasurement>().ReverseMap();
        }
    }
}
