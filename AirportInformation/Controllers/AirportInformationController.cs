using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirportInformation.DTO;
using AirportInformationServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirportInformation.Controllers
{
    [Route("api/[controller]")]
    public class AirportInformationController : Controller
    {
        private IAirportInformationService airportInformationService;

        public AirportInformationController(IAirportInformationService airportInformationService)
        {
            this.airportInformationService = airportInformationService;
        }

        [HttpGet("[action]")]
        public IEnumerable<AirportDTO> GetAllAirports()
        {
            var airports = airportInformationService.GetAllAirports();

            var result = airports.Select(a =>
                new AirportDTO()
                {
                    Iata = a.Iata,
                    Iso = a.Iso,
                    Status = a.Status,
                    Name = a.Name,
                    Continent = a.Continent.ToString(),
                    Type = a.Type.ToString(),
                    Size = a.Size.ToString(),
                    Coordinate = new GeoCoordinateDTO(a.Coordinate.Lon, a.Coordinate.Lat)
                });

            return result;
        }

        [HttpGet("[action]")]
        public IEnumerable<AirportDTO> GetAirportsByCountry(string country)
        {
            var airports = airportInformationService.GetAirportsByCountry(country);

            var result = airports.Select(a =>
                new AirportDTO()
                {
                    Iata = a.Iata,
                    Iso = a.Iso,
                    Status = a.Status,
                    Name = a.Name,
                    Continent = a.Continent.ToString(),
                    Type = a.Type.ToString(),
                    Size = a.Size.ToString(),
                    Coordinate = new GeoCoordinateDTO(a.Coordinate.Lon, a.Coordinate.Lat)
                });

            return result;
        }
    }
}