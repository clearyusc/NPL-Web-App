using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SimpleWebApp.Context;
using SimpleWebApp.Models;
using SimpleWebApp.Services;

namespace SimpleWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(env.ContentRootPath)
            //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            //    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
            //    .AddEnvironmentVariables();
            //Configuration = builder.Build();
            //_config = config;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            //options => options.UseSqlServer(Configuration.GetConnectionString("DefaultDevelopmentConnection")));
            services.AddDbContext<DefaultContext>(options => 
                options.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = SimpleWebApp; Trusted_Connection = True; MultipleActiveResultSets=true "));

            //services.AddDbContext<DefaultContext>(ops => ops.UseInMemoryDatabase("UserData"));

            //services.AddScoped<IUserData, SqlUserData>();


            // Use SQL Database if in Azure, otherwise, use SQLLite
            //if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
            //if (true)
            //    services.AddDbContext<DotNetCoreSqlDbContext>(options =>
            //            options.UseSqlServer(Configuration.GetConnectionString("DefaultProductionConnection")));
            //else
            //    services.AddDbContext<DotNetCoreSqlDbContext>(options =>
            //            options.UseSqlite("Data Source=MvcMovie.db"));

            //// Automatically perform database migration
            //services.BuildServiceProvider().GetService<DotNetCoreSqlDbContext>().Database.Migrate();

            //services.AddDbContext<DefaultContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
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

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
