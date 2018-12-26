using AirportInformation.Api.Client.RestObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportInformation.Api.Client.RequestActions
{
    internal interface IAirportInformationClientServices
    {
        List<RestAirport> GetAllAirportsInformation();
    }
}
