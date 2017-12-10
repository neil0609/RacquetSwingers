using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RacquetSwingers.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RacquetSwingers
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set;  }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            services.AddSingleton(Configuration);
            // Add IoC
            // services.AddSingleton<IGreeter, Greeter>();

            // injecting ioc and service
            // services.AddScoped<IRetaurantData, SqlRestaurantData>();
            // Adding EntityFrameWork DbContext
            services.AddDbContext<RacquetSwingersDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("RacquetSwingersCS")));

            services.AddDbContext<IdentityDbContext>(options => 
                    options.UseSqlServer(Configuration.GetConnectionString("RacquetSwingersCS"),
                    optionsBuilder => optionsBuilder.MigrationsAssembly("AspNetIdentityFromScratch")));
                    //optionsBuilder => optionsBuilder.MigrationsAssembly()));

            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<IdentityDbContext>()
                    .AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseIdentity();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            
        }
    }
}

//public Startup(IHostingEnvironment env)
//{
//    var builder = new ConfigurationBuilder()
//        .SetBasePath(env.ContentRootPath)
//        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
//        .AddEnvironmentVariables();
//    Configuration = builder.Build();
//}

//public IConfigurationRoot Configuration { get; }
