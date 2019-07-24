using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AirportInformation.DTO;
using AirportInformationServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirportInformation.Controllers
{
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Route("api/[controller]/[action]")]
    public class AirportInformationController : Controller
    {
        private readonly IAirportInformationService airportInformationService;

        public AirportInformationController(IAirportInformationService airportInformationService)
        {
            this.airportInformationService = airportInformationService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAllAirports()
        {
            var airports = await airportInformationService.GetAllAirports();

            var result =  airports.Select(a =>
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

            return Ok(result);
        }

        [HttpGet()]
        public async Task<IActionResult> GetAirportsByCountry(string country)
        {
            if (string.IsNullOrEmpty(country))
                return BadRequest();

            var airports = await airportInformationService.GetAirportsByCountry(country);
            if (airports == null || airports.Count == 0)
                return NotFound();

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

            return Ok(result);
        }
    }
}