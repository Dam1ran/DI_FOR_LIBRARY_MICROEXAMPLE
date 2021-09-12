using Microsoft.Extensions.DependencyInjection;
using FileWorkerLibrary.Extensions;

namespace ConsoleAppWithDi.Client
{
  public static class Startup
  {
    public static IServiceCollection ConfigureServices()
    {
      var serviceCollection = new ServiceCollection();
      serviceCollection.AddFileWorkerLibraryServices();
      return serviceCollection;
    }
  }
}