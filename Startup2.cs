using Microsoft.AspNetCore.Builder;
using Nancy.Owin;
namespace ConsoleApplication
{
   public class Startup2
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(x => x.UseNancy());
        }
   }
}