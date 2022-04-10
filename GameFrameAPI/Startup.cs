using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameFrameAPI
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GamedleAPI", Version = "v1" });
            });
            
            services.AddDbContext<GameFrameAPI.Models.GamedleDBContext>(
                options => options.UseMySQL(Configuration.GetConnectionString("MySQL")));

            services.AddCors(options =>
            {
                options.AddPolicy(name: "AllowLocalHost",
                    builder =>
                    {
                        /*builder.WithOrigins(
                            "http://localhost:3000",
                            "https://localhost:3000",
                            "http://jh-desktop:3000",
                            "https://jh-desktop:3000",
                            "http://192.168.1.165:3000",
                            "https://192.168.1.165:3000",
                            "http://jhmedia2:3000",
                            "https://jhmedia2:3000",
                            "http://192.168.1.155",
                            "https://192.168.1.155")
                            .AllowAnyMethod()
                            .AllowAnyHeader();*/

                        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseExceptionHandler("/error");

            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GamedleAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("AllowLocalHost");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers()
                    .RequireCors("AllowLocalHost"); ;
            });
        }
    }
}
