using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MoscowWiFi.LocalStorage.Tests
{
    public class LocalStorageAccessPointsRepositoryTests
    {
        private readonly DatasetContext _context;
        private readonly LocalStorageAccessPointRepository _repository;

        public LocalStorageAccessPointsRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<DatasetContext>()
                .UseInMemoryDatabase(databaseName: "Test")
                .Options;
            _context = new DatasetContext(options);
            _repository = new LocalStorageAccessPointRepository(_context);
        }

        [Fact]
        public async Task GetAllAccessPointsAsync_ShouldReturnAllAccessPoints()
        {
            var result = await _repository.GetAllAccessPointsAsync();
            
            Assert.NotEmpty(result);
            Assert.NotNull(result.ElementAt(0));
        }
    }
}