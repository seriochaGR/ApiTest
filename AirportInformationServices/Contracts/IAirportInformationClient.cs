using AirportInformationServices.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AirportInformationServices.Contracts
{
    public interface IAirportInformationClient
    {
        Task<IReadOnlyList<Airport>> GetAllAirportsInformation();
    }
}
