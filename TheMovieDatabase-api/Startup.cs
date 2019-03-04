using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TheMovieDatabase_api.Controllers;
using TheMovieDatabase_api.Models;
using TheMovieDatabase_api.Models.DataManager;

namespace TheMovieDatabase_api
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


            services.AddCors(options =>
            options.AddPolicy("Cors", builder =>
             {
                 builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();

             }));
            services.AddDbContext<dbContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:MovieDbs"]));
            services.AddScoped<IDataRepository<Movie>, MovieManager>();
            services.AddScoped<IDataRepository<Director>, DirectorManager>();
            services.AddScoped<IDataRepository<Actor>, ActorManager>();
            services.AddScoped<IDataRepository<User>, UserManager>();
            services.AddScoped<IDataRepositoryFortwo<Rating>, RatingManager>();
            services.AddScoped<IDataRepositoryFortwo<Favourite_Mov>, FavouriteManager>();
           
            services.AddScoped<IDataRepository<Movie_Cast>, MovieCastManger>();
            


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("Cors");

            app.UseMvc();
        }
    }
}
