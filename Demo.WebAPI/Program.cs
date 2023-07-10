using Demo.WebAPI.Data.Contexts;
using Demo.WebAPI.Data.Repositories;

using Microsoft.EntityFrameworkCore;

namespace Demo.WebAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<DefaultContext>(
            options => options.UseSqlServer("name=ConnectionStrings:Default"));

        builder.Services.AddScoped<IDefaultContext>(provider => provider.GetRequiredService<DefaultContext>());

        builder.Services.AddScoped<IPersonRepository, PersonRepository>();

        var app = builder.Build();

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
