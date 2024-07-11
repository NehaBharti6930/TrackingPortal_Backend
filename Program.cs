using Microsoft.EntityFrameworkCore;
using CoreAPI_Tracking.Models;

namespace CoreAPI_Tracking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

          //  string st = "server=.;database=CoreAPI_Trackingdb;trusted_connection=true";
           // builder.Services.AddDbContext<DA>(O => O.UseSqlServer(st));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            //builder.Services.AddDbContext<RFCContext>(opt =>
               //opt.PROJECTMANAGEMENTSYSTEM("RFCTable"));

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
