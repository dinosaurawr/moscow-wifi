using System;
using System.Collections.Generic;
using System.Text;

namespace MoscowWiFi.Core
{
    public class AccessPoint
    {
        public int GlobalId { get; set; }
        public string Name { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public int NumberOfAccessPoints { get; set; }
        public string WiFiName { get; set; }
        public int CoverageArea { get; set; }
        public string FunctionFlag { get; set; }
        public string AccessFlag { get; set; }
        public string Password { get; set; }
        public Location GeoData { get; set; }
    }
}
