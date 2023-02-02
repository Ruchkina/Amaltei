using AppAmalt.Repository;
using DatabaseContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AppAmalt
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
            var connectionString = Configuration.GetConnectionString("PostgreSQl");        
            services.AddControllers();
            services.AddTransient<IResponseRepository, ResponseRepository>();
            services.AddTransient<IAgeRepository, AgeRepository>();
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<IGenderRepository, GenderRepository>();
            services.AddTransient<ILifeMainRepository, LifeMainRepository>();
            services.AddTransient<IPoliticalRepository, PoliticalRepository>();
            services.AddTransient<IPortraitRepository, PortraitRepository>();
            services.AddTransient<IRelationRepository, RelationRepository>();
            services.AddTransient<IEducationRepository, EducationRepository>();
            services.AddEntityFrameworkNpgsql().AddDbContext<DatabaseContexts>(options =>
                options.UseNpgsql(connectionString));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
