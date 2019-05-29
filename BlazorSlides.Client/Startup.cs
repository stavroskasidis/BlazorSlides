using BlazorSlides.Client.Services.Contracts;
using BlazorSlides.Client.Services.Implementations;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorSlides.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IMarkdownService, MarkdownService>();
            services.AddSingleton<IInteropService, InteropService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
