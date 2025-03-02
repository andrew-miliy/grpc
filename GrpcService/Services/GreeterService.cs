using Grpc.Core;
using GrpcService;

namespace GrpcService.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    internal static HelloReply CreateHelloReply(string name)
    {
        return new HelloReply
        {
            Message = "Hello " + name
        };
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(CreateHelloReply(request.Name));
    }
}
