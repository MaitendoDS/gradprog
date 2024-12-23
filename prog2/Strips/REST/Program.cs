
using StripsBL.Interfaces;
using StripsBL.Models;
using StripsBL.Services;
using StripsDL;
using StripsDL.Repositories;


namespace REST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            builder.Services.AddDbContext<StripsContext>();

            builder.Services.AddScoped<IUitgeverijRepository, UitgeverijRepository>();
            builder.Services.AddScoped<UitgeverijService>();

            builder.Services.AddScoped<IReeksRepository, ReeksRepository>();
            builder.Services.AddScoped<ReeksService>();

            builder.Services.AddScoped<IStripRepository, StripRepository>();
            builder.Services.AddScoped<StripService>();

            builder.Services.AddScoped<IAuteurRepository, AuteurRepository>();
            builder.Services.AddScoped<AuteurService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
