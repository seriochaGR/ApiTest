using AirportInformationServices.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AirportInformationServices.Services
{
    public interface IAirportInformationService
    {
        Task<IReadOnlyList<Airport>> GetAllAirports();

        Task<IReadOnlyList<Airport>> GetAirportsByCountry(string country);
    }
}
