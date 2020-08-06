using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DihuiHuang.HotelSystem.Core.Entities;
using DihuiHuang.HotelSystem.Core.MappingProfiles;
using DihuiHuang.HotelSystem.Core.RepositoryInterfaces;
using DihuiHuang.HotelSystem.Core.ServiceInterfaces;
using DihuiHuang.HotelSystem.Infrastructure.Data;
using DihuiHuang.HotelSystem.Infrastructure.Repositories;
using DihuiHuang.HotelSystem.Infrastructure.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DihuiHuang.HotelSystem.API
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
            services.AddDbContext<HotelSystemDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("HotelSystemDbConnection")));
            services.AddAutoMapper(c => c.AddProfile<HotelMappingProfiles>(), typeof(Startup));

            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IRoomTypeRepository, RoomTypeRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IRoomTypeService, RoomTypeService>();
            services.AddScoped<ICustomerService, CustomerService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder =>
            {
                builder.WithOrigins(Configuration.GetValue<string>("clientSPAUrl")).AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
