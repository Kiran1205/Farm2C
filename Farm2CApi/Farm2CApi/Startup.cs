using Farm2CApi.DataAccess;
using Farm2CApi.DataAccess.Interface;
using Farm2CApi.Entities;
using Farm2CApi.Service;
using Farm2CApi.Service.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using Farm2CApi.Entities.Mapping;

namespace Farm2CApi
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
            services.AddDbContext<Farm2CEntities>(options =>
                       options.UseSqlServer(
                           Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllers();

            services.AddSwaggerGen();

            services.AddAutoMapper(typeof(Startup).Assembly);

            services.AddScoped<IDapper, Dapperr>();

            services.AddScoped<IHomeDataAccess, HomeDataAccess>();

            services.AddScoped<IHomeService, HomeService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
