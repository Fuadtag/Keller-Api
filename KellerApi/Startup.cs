using KellerApi.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace KellerApi
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
            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                    builder => builder.WithOrigins("http://localhost:4200")
                                                     .WithMethods("Get")
                                                     .AllowAnyHeader());
            });

            services.AddDbContext<KellerDbContext>(options =>
                options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddControllers().AddNewtonsoftJson();
            services.AddScoped<ContextService>();

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
            app.UseCors("AllowOrigin");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
