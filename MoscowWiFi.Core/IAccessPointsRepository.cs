using System.Collections.Generic;

namespace MoscowWiFi.Core
{
    public interface IAccessPointsRepository
    {
        IEnumerable<AccessPoint> GetAllAccessPoints();
    }
}