using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;
using MvcSample.Web.Services;


namespace KWebStartup
{
    public class Startup
    {
        public void Configure(IBuilder app)
        {
            app.UseErrorPage();

            app.UseServices(services =>
            {
                services.AddMvc();

                services.AddScoped<ITestContext, TestContext>();
            });

            app.UseMvc();

            app.UseWelcomePage();
        }
    }
}
