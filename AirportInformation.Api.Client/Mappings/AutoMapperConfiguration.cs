using AirportInformation.Api.Client.Mappings.Profiles;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportInformation.Api.Client.Mappings
{
    internal static class AutoMapperConfiguration
    {
        public static MapperConfiguration Configure()
        {
            ApplicationModelProfile applicationModelProfile = new ApplicationModelProfile();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(applicationModelProfile);
            });

            return config;
        }
    }
}
