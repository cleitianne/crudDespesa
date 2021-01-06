using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mobills.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using crudDespesa.Repositories.Interfaces;
using Mobills.Repositories;
using Mobills.Repositories.Interfaces;
using Mobills.Services.Interfaces;
using Mobills.Services;

namespace Mobills
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
             services.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
             services.AddSwaggerGen();

        
            services.AddScoped<IDespesaRepository, DespesaRepository>();
            services.AddScoped<IReceitaRepository, ReceitasRepository>();

            services.AddScoped<IDespesaService, DespesaService>();
            services.AddScoped<IReceitaService, ReceitaService>();
            services.AddScoped<IConsultaService, ConsultaService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

	        app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); });
        }
    }
}
