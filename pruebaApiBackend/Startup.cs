using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using pruebaApiBackend.DataAccess;

namespace pruebaApiBackend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Este método se utiliza para agregar servicios al contenedor.
        public void ConfigureServices(IServiceCollection services)
        {
            // Configurar el contexto de la base de datos
            services.AddDbContext<PruebaDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Configurar CORS para permitir solicitudes desde http://localhost:3000
            services.AddCors(options =>
            {
                options.AddPolicy("AllowReact",
                    builder => builder.WithOrigins("http://localhost:3000")
                                      .AllowAnyHeader()
                                      .AllowAnyMethod());
            });

            services.AddControllers();
        }

        // Este método se utiliza para configurar el pipeline de solicitud HTTP.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Redirigir solicitudes HTTP a HTTPS
            app.UseHttpsRedirection();

            // Habilitar CORS
            app.UseCors("AllowReact");

            // Habilitar enrutamiento
            app.UseRouting();

            // Habilitar autorización
            app.UseAuthorization();

            // Configurar el enrutamiento de endpoints de controladores
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
