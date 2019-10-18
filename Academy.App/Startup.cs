using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Academy.DataAccessLayer.IRepository;
using Academy.DataAccessLayer.Repository;
using Academy.Service.IServices;
using Academy.Service.Services;
using System.Reflection;

namespace Academy.App
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            /// <summary>
            /// date: 1398/07/12
            /// Description: Add Academy.App Like Application Part To Launcher Project 
            /// Creator: MohammadReza Aghaei
            /// </summary>
            services.AddMvc().AddApplicationPart(Assembly.Load(new AssemblyName("Academy.Api")));

            /// <summary>
            /// date: 1398/07/12
            /// Description: Add DataBaseContext services.
            /// Creator: MohammadReza Aghaei
            /// </summary>
            //services.AddDbContext<AcademyDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            /// <summary>
            /// date: 1398/07/12
            /// Description: Add services.
            /// Creator: MohammadReza Aghaei
            /// </summary>
            //services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
            services.AddTransient(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            services.AddTransient(typeof(IGenericService<,>), typeof(GenericService<,>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            /// <summary>
            /// date: 1398/07/12
            /// Description: Add Api routing To Project.
            /// Creator: MohammadReza Aghaei
            /// </summary>
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "api", template: "api/{controller=Teacher}");
                routes.MapRoute(name: "default", template: "{controller=Teacher}/{action=ListAsync}/{id?}");
            });
        }
    }
}
