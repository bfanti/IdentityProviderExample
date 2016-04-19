using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace IdentityProvider
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        	services.AddMvcCore()
        		    .AddJsonFormatters();
        }

        public void Configure(IApplicationBuilder app)
        {
			app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller}/{action}");
            });
        }
    }
}	