using CleanArch.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace CleanArch.Mvc2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Started CleanArch.Mvc..");
            Console.WriteLine("Skipping standard UI ..");
            //This following statement was throwing an error
            //MediatR crap and seems so far resolved (see DependencyContainer) 
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
