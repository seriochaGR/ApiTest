using AirportInformation.Api.Client.Mappings;
using AirportInformation.Api.Client.RequestActions;
using AirportInformation.Api.Client.RestObjects;
using AirportInformationServices.Contracts;
using AirportInformationServices.Models;
using AirportInformationServices.Models.Exceptions;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AirportInformation.Api.Client
{
    public sealed class AirportInformationClient : IAirportInformationClient
    {
        private IAirportInformationClientServices airportInformationServices;
        private IMapper mapper;

        public AirportInformationClient()
        {
            airportInformationServices = new AirportInformationClientServices();

            var mapperConfig = AutoMapperConfiguration.Configure();
            mapper = mapperConfig.CreateMapper();
        }

        public async Task<IReadOnlyList<Airport>> GetAllAirportsInformation()
        {
            try
            {
                var restInformation = await airportInformationServices.GetAllAirportsInformation();
                var resultList = mapper.Map<IReadOnlyList<RestAirport>, IReadOnlyList<Airport>>(restInformation);
                return resultList;
            }
            catch (AirportInformationClientException ex)
            {
                throw ex;
            }
        }
    }
}
