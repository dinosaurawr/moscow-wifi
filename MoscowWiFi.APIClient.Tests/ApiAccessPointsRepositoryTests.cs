using System.Linq;
using System.Threading.Tasks;
using Xunit;
using MoscowWiFi.WebClient;

namespace MoscowWiFi.ApiClient.Tests
{
    public class ApiAccessPointsRepositoryTests
    {
        private readonly ApiAccessPointsRepository _repository;
        public ApiAccessPointsRepositoryTests()
        {
            _repository = new ApiAccessPointsRepository();
        }
        
        [Fact]
        public async Task GetAllAccessPointsAsync_ShouldReturnAllAccessPoints()
        {
            var result = await _repository.GetAllAccessPointsAsync();
            
            Assert.NotEmpty(result);
            Assert.NotNull(result.ElementAt(0));
        }

        [Fact]
        private void GetAllAccessPoints_ShouldReturnAllAccessPoints()
        {
            var result = _repository.GetAllAccessPoints();
            
            Assert.NotEmpty(result);
            Assert.NotNull(result.ElementAt(0));
        }
    }
}