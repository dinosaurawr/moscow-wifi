using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MoscowWiFi.Core;
using MoscowWiFi.WebClient.ResponseModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace MoscowWiFi.WebClient
{
    public class ApiAccessPointsRepository : IAccessPointsRepository
    {
        public async Task<IEnumerable<AccessPoint>> GetAllAccessPointsAsync()
        {
            var request = new RestRequest($"datasets/{APISettings.DatasetID}/rows", DataFormat.Json);
            return ApiClient.Client.GetAsync<List<RowsResponseModel>>(request).Result.Select(rrm => rrm.Cells);
        }

        public IEnumerable<AccessPoint> GetAllAccessPoints()
        {
            var request = new RestRequest($"datasets/{APISettings.DatasetID}/rows", DataFormat.Json);
            return ApiClient.Client.Get<List<RowsResponseModel>>(request).Data.Select(rrm => rrm.Cells);
        }

        public DateTime GetDatasetLastUpdateTime()
        {
            var request = new RestRequest($"datasets/{APISettings.DatasetID}", DataFormat.Json);
            JToken jsonDate;
            var successful = JObject.Parse(ApiClient.Client.Get(request).Content).TryGetValue("VersionDate", out jsonDate);
            return successful ? DateTime.Parse(jsonDate.ToString()) : DateTime.Today;
        }
    }
}