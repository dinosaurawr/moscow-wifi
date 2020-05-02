using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoscowWiFi.Core;
using MoscowWiFi.WebClient.ResponseModels;
using RestSharp;

namespace MoscowWiFi.WebClient
{
    public class ApiAccessPointsRepository : IAccessPointsRepository
    {
        public async Task<IEnumerable<AccessPoint>> GetAllAccessPointsAsync()
        {
            var request = new RestRequest($"datasets/{APISettings.DatasetID}/rows", DataFormat.Json);
            return APIClient.Client.GetAsync<List<RowsResponseModel>>(request).Result.Select(rrm => rrm.Cells);
        }

        public IEnumerable<AccessPoint> GetAllAccessPoints()
        {
            var request = new RestRequest($"datasets/{APISettings.DatasetID}/rows", DataFormat.Json);
            return APIClient.Client.Get<List<RowsResponseModel>>(request).Data.Select(rrm => rrm.Cells);
        }
    }
}