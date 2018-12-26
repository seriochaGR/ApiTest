using AirportInformation.Api.Client.RestObjects;
using AirportInformationServices.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportInformation.Api.Client.Mappings.Profiles
{
    internal class ApplicationModelProfile : Profile
    {
        public ApplicationModelProfile()
        {
            CreateMap<RestAirport, Airport>()                
                .ForMember(dest => dest.Coordinate,
                map => map.MapFrom(src => new GeoCoordinate(src.Lon, src.Lat)));
        }        
    }
}
