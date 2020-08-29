using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using inventory.api.Options;
using inventory.api.Repository;
using Microsoft.Extensions.Hosting;
using inventory.api.Models;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace inventory.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(typeof(IDataContext<>), typeof(DataContext<>));

            services.AddSingleton(typeof(IRepository<>), typeof(MongoRepository<>));

            services.Configure<InventoryOptions>(Configuration.GetSection("Inventory"));
            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // app.UseHttpsRedirection();
            app.UseRouting();

            var resourceFolderPath = Path.Combine(env.ContentRootPath, "Resources");
            Directory.CreateDirectory(resourceFolderPath);

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(resourceFolderPath),
                RequestPath = "/Resources"
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
