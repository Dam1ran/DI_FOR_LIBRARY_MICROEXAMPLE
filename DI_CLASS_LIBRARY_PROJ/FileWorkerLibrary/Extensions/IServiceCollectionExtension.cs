using Microsoft.Extensions.DependencyInjection;
using Abstractions;
using Implementations;

namespace FileWorkerLibrary.Extensions
{
  public static class IServiceCollectionExtension
  {
    public static IServiceCollection AddFileWorkerLibraryServices(this IServiceCollection services)
    {
      services.AddTransient<Entry>();
      services.AddTransient<IRepository, Repository>();
      // other Add....
      return services;
    }
  }
}