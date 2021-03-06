using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MsfTeamBuilderAPI.Helpers;
using MsfTeamBuilderAPI.Models;
using MsfTeamBuilderAPI.Models.BaseToons;
using MsfTeamBuilderAPI.Models.Entities;
using MsfTeamBuilderAPI.Services;
using MsfTeamBuilderAPI.Services.BaseToon;
using MsfTeamBuilderAPI.Services.DataBase;
using MsfTeamBuilderAPI.Services.DataBase.SqLite;
using MsfTeamBuilderAPI.Services.Interfaces;
using MsfTeamBuilderAPI.Services.Interfaces.BaseToon;
using Swashbuckle.AspNetCore.Swagger;

namespace MsfTeamBuilderAPI
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
      services.AddCors();
      // Auto Mapper Configurations
      var mappingConfig = new MapperConfiguration(mc =>
      {
        mc.AddProfile(new AutoMapperProfile());
      });
      IMapper mapper = mappingConfig.CreateMapper();
      services.AddSingleton(mapper);
      services.AddTransient<IDbInterface<BaseToon>, SqLiteToonDb>();
      services.AddSingleton<IGetBaseToonService, GetBaseToonService>();
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

      // Register the Swagger generator, defining 1 or more Swagger documents
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
      });

      // configure strongly typed settings objects
      var appSettingsSection = Configuration.GetSection("AppSettings");
      services.Configure<AppSettings>(appSettingsSection);

      // In production, the Angular files will be served from this directory
      services.AddSpaStaticFiles(configuration =>
      {
        configuration.RootPath = "ClientApp/dist";
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        // Enable middleware to serve generated Swagger as a JSON endpoint.
        app.UseSwagger();
        app.UseDeveloperExceptionPage();
        app.UseSwaggerUI(c =>
        {
          c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        });
      }
      else
      {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseStaticFiles();
      app.UseSpaStaticFiles();

      app.UseMvc(routes =>
      {
        routes.MapRoute(
                  name: "default",
                  template: "{controller}/{action=Index}/{id?}");
      });

      app.UseSpa(spa =>
      {
              // To learn more about options for serving an Angular SPA from ASP.NET Core,
              // see https://go.microsoft.com/fwlink/?linkid=864501

              spa.Options.SourcePath = "ClientApp";

        if (env.IsDevelopment())
        {
          spa.UseAngularCliServer(npmScript: "start");
        }
      });
    }
  }
}
