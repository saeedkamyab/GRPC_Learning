using ServerApp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc();
var app = builder.Build();
app.UseHttpsRedirection();
app.UseRouting();
app.MapGet("/", () => "Hello World!");
app.UseEndpoints(endpoints => endpoints.MapGrpcService<HelloGrpcService>());
app.Run();
