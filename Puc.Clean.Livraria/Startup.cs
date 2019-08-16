using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Puc.Clean.Livraria.Application;
using Puc.Clean.Livraria.Application.Repositories;
using Puc.Clean.Livraria.Application.UseCases.CreateBook;
//using Puc.Clean.Livraria.Infrastructure.DataAccess;
using Swashbuckle.AspNetCore.Swagger;

namespace Puc.Clean.Livraria
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddScoped<IInputBoundary<CreateBookInput>, CreateBookInteractor>();
            //services.AddScoped<IBookWriteOnlyRepository, BookRepository>();
            //services.AddScoped<IBookReadOnlyRepository, BookRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Book Store API",
                    Description = "Book Store API",
                    TermsOfService = "None",
                    Contact = new Contact() { Name = "Pedro Giovannini", Email = "pedrogiovannini@gmail.com", Url = "www.google.com" }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
