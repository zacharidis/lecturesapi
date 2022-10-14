using lecturesapi.Data;
using lecturesapi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace lecturesapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // insert db context 

            builder.Services.AddDbContext<LanguagesDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("LanguagesConn"));

            });

            //whenever i use the Interface give me the impl
            builder.Services.AddScoped<ILanguageRepository, LanguageRepositoryIMPL>();


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