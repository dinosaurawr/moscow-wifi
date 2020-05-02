using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoscowWiFi.Core
{
    public interface IAccessPointsRepository
    {
        Task<IEnumerable<AccessPoint>> GetAllAccessPointsAsync();
        IEnumerable<AccessPoint> GetAllAccessPoints();
    }
}