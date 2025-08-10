using Grpc.Net.Client;
using ServerApp.Service.Proto;
using static ServerApp.Service.Proto.HelloService;

class Program
{
    static void Main(string[] args)
    {
        GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:7070/");
        HelloServiceClient helloService = new HelloServiceClient(channel);
        var request = new request { Name = "Saeid" };
        Console.WriteLine(helloService.SayHello(request)) ;
    }
}
