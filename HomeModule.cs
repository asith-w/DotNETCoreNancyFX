
using Nancy;

namespace ConsoleApplication
{
        public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Hello World, it's Nancy on .NET Core");
             
        }
    }
}