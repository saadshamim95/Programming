//-----------------------------------------------------------------------
// <copyright file="Startup.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace EmployeeManagementSystem
{
    using EmployeeManagementSystem.Manager;
    using EmployeeManagementSystem.Repository;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Startup Class
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// The configuration
        /// </summary>
        private IConfiguration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public Startup(IConfiguration config)
        {
            this.configuration = config;
        }

        /// <summary>
        /// Configures the services.
        /// </summary>
        /// <param name="services">The services.</param>
        //// This method gets called by the runtime. Use this method to add services to the container.
        //// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940 
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1);
            services.AddSingleton<IConfiguration>(this.configuration);
            services.AddTransient<IRepository, RepositoryImpl>();
            services.AddTransient<IManager, ManagerImpl>();
        }

        /// <summary>
        /// Configures the specified application.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <param name="env">The env.</param>
        //// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Employee}/{action=UpdateEmployee}/{id?}");
            });
        }
    }
}