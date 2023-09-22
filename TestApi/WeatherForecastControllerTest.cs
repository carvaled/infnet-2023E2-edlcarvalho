using DockerInfNet_Edlcarvalho.Controllers;

namespace TestApi
{
    public class UnitTest1
    {
        [Fact]
        public void DeveFazerGetComSucesso()
        {
            var controller = new WeatherForecastController();

            var result = controller.Get();

            Assert.True(result.Any());
        }
    }
}