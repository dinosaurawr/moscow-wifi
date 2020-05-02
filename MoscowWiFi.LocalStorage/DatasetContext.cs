using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MoscowWiFi.Core;

namespace MoscowWiFi.LocalStorage
{
    public class DatasetContext : DbContext
    {
        public DatasetContext()
        {
        }

        public DatasetContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AccessPoint> AccessPoints { get; set; }
        public DbSet<string> LastUpdate { get; set; }
    }
}