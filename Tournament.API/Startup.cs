using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Owin;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Tournament.Data;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors.Infrastructure;
using System.IO;
using System.Text;
using System.Globalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Abstractions;
using Tournament.Business;

namespace Tournament.API
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddDbContext<TournamentDbContext>(options => options
                .UseSqlServer(_config.GetConnectionString("TournamentDb")));

            services.AddScoped<UserService>();

            services.AddAuthentication().AddSteam();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {                
                app.UseDeveloperExceptionPage();
            }            

            //TODO
            //Fixa lite med authentifiering

            app.UseMiddleware(); //Nifty encapsulation with the extension                  

            app.UseCors(builder => builder.WithOrigins("https://localhost:44378", "http://localhost:50891"));

            app.UseMvc();

        }


    }
}
