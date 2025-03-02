using GrpcService.Services;
using Shouldly;

namespace GrpcService.Tests
{
    public class GreeterServiceTests
    {
        [Theory]
        [InlineData("", "Hello ")]
        [InlineData("John", "Hello John")]
        public void CreateHelloReply_ReturnsExpectedMessage(string name, string expectedResult)
        {
            // Arrange
            
            // Act
            HelloReply reply = GreeterService.CreateHelloReply(name);

            // Assert
            reply.ShouldNotBeNull();
            reply.Message.ShouldBe(expectedResult);
        }
    }
}
