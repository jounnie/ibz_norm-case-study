using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LastMinuteServiceClient
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<FlightsService, FlightsService>();

            

        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
            
        }
    }
}
