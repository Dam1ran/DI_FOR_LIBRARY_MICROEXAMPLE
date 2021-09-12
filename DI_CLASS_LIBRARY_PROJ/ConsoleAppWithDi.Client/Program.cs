using System;
using Microsoft.Extensions.DependencyInjection;
using FileWorkerLibrary;

namespace ConsoleAppWithDi.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = Startup.ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService<Entry>().Start(args);


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
