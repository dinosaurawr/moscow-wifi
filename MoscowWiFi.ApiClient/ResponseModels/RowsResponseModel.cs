using MoscowWiFi.Core;

namespace MoscowWiFi.WebClient.ResponseModels
{
    public class RowsResponseModel
    {
        public double Number { get; set; }
        public AccessPoint Cells { get; set; }
    }
}