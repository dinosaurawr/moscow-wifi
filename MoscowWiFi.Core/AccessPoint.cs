using System;
using System.Collections.Generic;
using System.Text;

namespace MoscowWiFi.Core
{
    public class AccessPoint
    {
        public string AdministrativeDistrict { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public int NumberOfAccessPoints { get; set; }
        public int Coverage { get; set; }
        public Location Location { get; set; }
    }
}
