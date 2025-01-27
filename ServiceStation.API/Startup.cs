using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;
using ServiceStation.API.Auth;
using System;

namespace ServiceStation.API
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

            services.AddTransient(_ => new DatabaseContext());

            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ServiceStation API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DatabaseContext databaseContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseMiddleware<AuthMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "ServiceStation API V1");
            });

            try
            {
                databaseContext.Database.Migrate();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occured during database migrations");
            }

            var logConfig = new LoggerConfiguration().WriteTo.MSSqlServer(databaseContext.Database.GetDbConnection().ConnectionString, new MSSqlServerSinkOptions { AutoCreateSqlTable = true, TableName = "logging" }, null, null, LogEventLevel.Verbose);

            Log.Logger = logConfig.CreateLogger();
        }
    }
}
