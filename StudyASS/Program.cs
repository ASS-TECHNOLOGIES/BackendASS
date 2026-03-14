using StudyASS.Factories;
using StudyASS.Interfaces;
using StudyASS.Parsers;

namespace StudyASS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            // Register extra objects
            builder.Services.AddSingleton<IStudySessionFactory, StudySessionFactory>();
            builder.Services.AddSingleton<IDatabaseParser, ConsoleOutputter>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
