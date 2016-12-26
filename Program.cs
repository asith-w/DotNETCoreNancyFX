using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
 
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                 //.Configure(app => { 
            //    app.Run(context => context.Response.WriteAsync("Hello dotnet core") );
            //})
                .UseStartup<Startup>()
                .Build();
 
            host.Run();  

          }
    }
}
