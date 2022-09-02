using BlogProjetoFinal.Domain;
using Liquid.Repository.EntityFramework.Extensions;
using BlogProjetoFinal.Domain.Entities;
using BlogProjetoFinal.Repository;
using Liquid.WebApi.Http.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Liquid.Core.Extensions.DependencyInjection;

namespace BlogProjetoFinal.WebApi
{
    public class Startup
    {

        /// <summary>
        ///     Startup Constructor
        /// </summary>
        /// <param name="configuration">
        ///     Object IConfiguration
        /// </param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        ///     Object IConfiguration
        /// </summary>
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLiquidConfiguration();
            services.AddLiquidHttp(typeof(IDomainInjection).Assembly);

            void dbContextOptionsBuilder(DbContextOptionsBuilder options)
            {
                var connectionString = Configuration["ConnectionString:LiquidDbContext"];
                options.UseSqlServer(connectionString, b => b.MigrationsAssembly(typeof(LiquidDbContext).Assembly.FullName));
            }
            services.AddDbContext<LiquidDbContext>(dbContextOptionsBuilder);

            services.AddLiquidEntityFramework<LiquidDbContext, UsuarioEntity, Guid>(dbContextOptionsBuilder);
            services.AddLiquidEntityFramework<LiquidDbContext, ArtigoEntity, int>(dbContextOptionsBuilder);
            services.AddLiquidEntityFramework<LiquidDbContext, CategoriaEntity, int>(dbContextOptionsBuilder);

            services.AddControllers();

            services.AddLogging();

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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors();

            app.UseLiquidConfigure();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
