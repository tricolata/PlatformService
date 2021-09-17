# Microservices
Two services. PlatformService & CommandService

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