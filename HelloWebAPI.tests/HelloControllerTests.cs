using HelloWebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebAPI.tests
{
    public class HelloControllerTests
    {
        [Fact]
        public void Get_ReturnsHelloWorld()
        {
            var controller = new HelloController();
            var okResult = Assert.IsType<OkObjectResult>(controller.Get());
            Assert.Equal("Hallow World", okResult.Value);
        }
    }
}