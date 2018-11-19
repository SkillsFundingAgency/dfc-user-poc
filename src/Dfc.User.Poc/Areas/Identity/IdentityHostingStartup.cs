using System;
using Dfc.User.Poc.Areas.Identity.Data;
using Dfc.User.Poc.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Dfc.User.Poc.Areas.Identity.IdentityHostingStartup))]
namespace Dfc.User.Poc.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DfcUserPocContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DfcUserPocContextConnection")));

                //services.AddDefaultIdentity<DfcUserPocUser>()
                //    .AddEntityFrameworkStores<DfcUserPocContext>();
            });
        }
    }
}