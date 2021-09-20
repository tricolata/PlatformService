# Microservices
We are creating two services as microservice. PlatformService & CommandService.\
Both will communicate via REST API & Rabbit MQ.\
This app is PlatformService. CommandService is located at another repo.

# PlatformServices
- Function as an "Asset Register"
- Tracks all the platforms
- Communicates with API Gateway via REST API
- Communicates with CommandService via RabbitMQ
- Receive event from CommandService via Grpc 

- DB - SQL Server

To run program, `dotnet run` 

## Reference
.NET Microservices - Full Course by Les Jackson
