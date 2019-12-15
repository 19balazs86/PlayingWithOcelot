using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Gateway.Api
{
  public class Program
  {
    public static void Main(string[] args)
    {
      createHostBuilder(args).Build().Run();
    }

    private static IHostBuilder createHostBuilder(string[] args)
    {
      return Host
        .CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webHostBuilder =>
          webHostBuilder
            .ConfigureAppConfiguration((hostContext, configBuilder) => configBuilder.AddJsonFile("ocelot.json"))
            .UseStartup<Startup>());
    }
  }
}
