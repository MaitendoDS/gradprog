using FitnessBL.Interfaces;
using FitnessBL.Services;
using FitnessDL;
using FitnessDL.Repositories;


public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddDbContext<FitnessContext>();

        builder.Services.AddScoped<IMemberRepository, MemberRepository>();
        builder.Services.AddScoped<MemberService>();

        builder.Services.AddScoped<IProgrammaRepository, ProgrammaRepository>();
        builder.Services.AddScoped<ProgrammaService>();

        builder.Services.AddScoped<IEquipmentRepository, EquipmentRepository>();
        builder.Services.AddScoped<EquipmentService>();


        builder.Services.AddScoped<IRunningSessionRepository, RunningSessionRepository>();
        builder.Services.AddScoped<RunningSessionService>();

        builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
        builder.Services.AddScoped<ReservationService>();



        // Voeg hier de JsonOptions toe om circulaire referenties te ondersteunen
        builder.Services.AddControllers();

        // Add services to the container
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        // Use CORS middleware before authorization
        app.UseCors("AllowReactApp");

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}