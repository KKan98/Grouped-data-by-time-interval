using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using GroupedData.Application.Features;
using GroupedData.Application.Features.DeleteActivity;
using GroupedData.Application.Features.EditActivity;
using GroupedData.Application.Features.RegistrationActivity;
using GroupedData.Application.Infrastructure;
using GroupedData.Domain.Activity;
using GroupedData.Infrastructure;
using GroupedData.Presentation.Activity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GrupedDataUI
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
 
            services.AddRazorPages();

            services.AddScoped<ICommandHandler<RegistrationActivityCommand>, RegistrationActivityCommandHandler>();
            services.AddScoped<IActivityFactory,ActivityFactory>();
            services.AddScoped<IActivityRepository, ActivityRepository>();
            services.AddScoped<IActivityPresentationRepository, ActivityPresentationRepository>();
            services.AddScoped<ICommandHandler<EditActivityCommand>, EditActivityCommandHandler>();
            services.AddScoped<ICommandHandler<DeleteActivityCommand>, DeleteActivityCommandHandler>();

            services.AddSingleton<IInMemoryDb<ActivityEntity>, InMemoryActivity>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
