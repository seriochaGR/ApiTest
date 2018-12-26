using AirportInformation.Api.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace AirportInformation.Test
{
    public sealed class AirportInformationClientTest
    {
        private AirportInformationClient airportInformationClient;

        public AirportInformationClientTest()
        {
            airportInformationClient = new AirportInformationClient();
        }

        [Fact]
        public void GetAllAirportsInformationTestOk()
        {
            var airports = airportInformationClient.GetAllAirportsInformation();

            Assert.NotNull(airports);
            Assert.NotEmpty(airports);
        }
    }
}
