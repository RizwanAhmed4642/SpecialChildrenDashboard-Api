using FluentAssertions.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SpecialChildrenDashboard_Api.BAL.Interface;
using SpecialChildrenDashboard_Api.BAL.Service;
using SpecialChildrenDashboard_Api.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        private const string secretKey = "this_is_my_case_secret-Key-for-token_generation";
        public static readonly SymmetricSecurityKey signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {



           

            services.AddMvc()
            .AddSessionStateTempDataProvider();
            services.AddSession();
            services.AddMemoryCache();



            
            services.AddTransient<ICounterDashboard, CounterDashboard>();
        




            services.AddDbContext<SpecialChildrenContext>(item => item.UseSqlServer(Configuration.GetConnectionString("ConnectionString")));
            services.AddControllers();
            services.AddCors(options =>
            {
                options.AddPolicy(
                    name: "AllowOrigin",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader();
                    });
            });
            //services.AddSingleton<IUriService>(o =>
            //{
            //    var accessor = o.GetRequiredService<IHttpContextAccessor>();
            //    var request = accessor.HttpContext.Request;
            //    var uri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
            //    return new UriService(uri);
            //});

            services.AddControllers()
                            .AddJsonOptions(options =>
                            {
                                options.JsonSerializerOptions.PropertyNamingPolicy = null;
                            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Special Children", Version = "v1" });
            });



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();

            if (env.IsDevelopment() || env.IsProduction())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HF Roster  v1"));
            }
            //app.UseStaticFiles();
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(
            //                Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot")),
            //    RequestPath = new PathString("/wwwroot")
            //});

            app.UseAuthentication();

            // app.UseCors(options =>
            //options.WithOrigins("http://localhost:4200")
            //.AllowAnyMethod()
            //.AllowAnyHeader());
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            //app.UseHttpsRedirection();


            app.UseRouting();
            //configurations to cosume the Web API from port : 4200 (Angualr App)
            // global cors policy
            app.UseCors(x => x
                   .AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader());

            //app.UseHttpsRedirection();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
