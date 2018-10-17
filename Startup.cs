using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace CoreTemplate {
    public class Startup {
        public void ConfigureServices (IServiceCollection services) {
            services.AddMemoryCache();
            services.AddLogging();
            services.AddResponseCompression();
            services.AddMvc().AddRazorPagesOptions(options =>
            {
                options.Conventions.AddPageRoute("/docs", "");
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "TFL Explorer",
                    Contact = new Contact() { Email = "armandombi@gmail.com" },
                    Version = "v1"
                });
            });
        }
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
                app.UseWebpackDevMiddleware (new WebpackDevMiddlewareOptions {
                    HotModuleReplacement = true
                });
            }
            app.UseStaticFiles ();
            app.UseStatusCodePages();
            app.UseResponseCompression();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TFL Explorer V1");
                c.RoutePrefix = "docs";
                c.EnableDeepLinking();
                c.EnableValidator();
                c.DisplayRequestDuration();
            });
            app.UseMvc (routes => {
                routes.MapRoute (
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}