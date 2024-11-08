using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SinistroOdontoApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Este método é chamado pelo runtime. Use este método para adicionar serviços ao contêiner.
        public void ConfigureServices(IServiceCollection services)
        {
            // Adiciona serviços de controladores com views (MVC)
            services.AddControllersWithViews();

            // Adiciona serviços de Razor Pages, se necessário
            services.AddRazorPages();

            // Adicione outros serviços necessários, como banco de dados, autenticação, etc.
        }

        // Este método é chamado pelo runtime. Use este método para configurar o pipeline de requisição HTTP.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // O padrão HSTS é usado para segurança.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // Define a rota padrão para controladores
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                // Adiciona suporte para Razor Pages, se necessário
                endpoints.MapRazorPages();
            });
        }
    }
}
