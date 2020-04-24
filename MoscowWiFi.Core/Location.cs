using System;
using System.Collections.Generic;
using System.Text;

namespace MoscowWiFi.Core
{
    public struct Location
    {
        public Location(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public double Longitude { get; }
        public double Latitude { get; }
    }
}
