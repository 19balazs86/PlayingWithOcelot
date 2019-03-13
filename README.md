# Playing with Ocelot

This is a small .NET Core WebAPI application to try out Ocelot. Which is an open-source .NET Core API Gateway.

### Getting Started:
1. Nuget: Install-Package Ocelot.
2. Configuration: create ocelot.json and define the ReRoutes.
3. Program: configBuilder.AddJsonFile("ocelot.json").
4. Startup: services.AddOcelot(Configuration).
5. Startup: app.UseOcelot().
6. Run.

Resources:
- [Ocelot](https://ocelot.readthedocs.io "Ocelot") home page, documentation.
- [Ocelot - GitHub page](https://github.com/ThreeMammals/Ocelot "Ocelot - GitHub page").
- Medium article: [Microservices API Gateways - Ocelot for .NET Core + Video](https://medium.com/hypertrends/microservices-api-gateways-ocelot-for-net-core-video-8bbd4ed3be8f "Microservices API Gateways - Ocelot for .NET Core + Video").
- Microsoft page: [Implement API Gateways with Ocelot](https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/multi-container-microservice-net-applications/implement-api-gateways-with-ocelot "Implement API Gateways with Ocelot").
- Blog Part 1: [API Gateway in a Nutshell](https://www.pogsdotnet.com/2018/08/api-gateway-in-nutshell.html "API Gateway in a Nutshell") | Part 2: [API Gateways with Ocelot](https://www.pogsdotnet.com/2018/08/building-simple-api-gateways-with.html "Building Simple API Gateways with Ocelot and ASP.net Core") | Part 3: [Response Aggregation](https://www.pogsdotnet.com/2018/09/api-gateway-response-aggregation-with.html "Response Aggregation").
- Altkom Software blog: [Building Microservices on .NET Core - API Gateways With Ocelot](https://altkomsoftware.pl/en/blog/building-api-gateways-with-ocelot/ "Building Microservices on .NET Core - API Gateways With Ocelot").
