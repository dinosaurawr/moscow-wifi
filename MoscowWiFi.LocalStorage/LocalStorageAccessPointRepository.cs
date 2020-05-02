using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoscowWiFi.Core;

namespace MoscowWiFi.LocalStorage
{
    public class LocalStorageAccessPointRepository : IAccessPointsRepository
    {
        private readonly DatasetContext _context;
        public LocalStorageAccessPointRepository(DatasetContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<AccessPoint>> GetAllAccessPointsAsync()
        {
            using var context = _context;
            return context.AccessPoints.ToListAsync().Result;
        }

        public IEnumerable<AccessPoint> GetAllAccessPoints()
        {
            using var context = _context;
            return context.AccessPoints.ToList();
        }
        
        public bool ShouldAccessPointsSyncWithDataset(DateTime lastDatasetUpdateTime)
        {
            var stringLastUpdate = _context.LastUpdate.FirstOrDefault() ?? DateTime.Now.ToString();
            var lastUpdate = DateTime.Parse(stringLastUpdate);
            return lastUpdate < lastDatasetUpdateTime;
        }

        public void UpdateAllAccessPoints(IEnumerable<AccessPoint> points)
        {
            using var context = _context;
            context.AccessPoints.UpdateRange(points);
        }
    }
}