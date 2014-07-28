using Microsoft.AspNet.Builder;

namespace KWebStartup
{
    public class Startup
    {
        public void Configure(IBuilder app)
        {
            app.UseErrorPage();

            app.UseStaticFiles();
            app.UseWelcomePage();
        }
    }
}