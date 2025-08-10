using Grpc.Core;
using ServerApp.Service.Proto;

namespace ServerApp
{
    public class HelloGrpcService : HelloService.HelloServiceBase
    {
        public override async Task<response> SayHello(request request, ServerCallContext context)
        {
            Console.WriteLine("Hi " + request);
            return await Task.FromResult(new response { Message = "Hi " + request });
        }
    }
}
