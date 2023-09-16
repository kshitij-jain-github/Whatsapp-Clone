
[assembly: HostingStartup(typeof(Whatsapp.Clone.Areas.Identity.IdentityHostingStartup))]

namespace Whatsapp.Clone.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}
