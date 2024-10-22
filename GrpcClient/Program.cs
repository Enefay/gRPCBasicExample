using Grpc.Net.Client;
using GrpcServer;

var channel = GrpcChannel.ForAddress("https://localhost:7005");
var greetClient = new Greeter.GreeterClient(channel);


HelloReply helloReply =  await greetClient.SayHelloAsync(new HelloRequest 
{ 
    Name = "Berk" 
});  


Console.WriteLine(helloReply.Message);


Console.ReadLine();