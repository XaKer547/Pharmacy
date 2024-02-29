using Microsoft.EntityFrameworkCore;
using PharmacyApi.Data;
using PharmacyApi.Data.Entities.Seeder;
using PharmacyApi.Services;
using PharmacyApi.Services.Interfaces;

namespace PharmacyApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<PharmacyDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped<IMedicineManager, MedicineManager>();
            builder.Services.AddScoped<IMedicineService, MedicineService>();
            builder.Services.AddScoped<IWarehouseManager, WarehouseManager>();
            builder.Services.AddScoped<IWarehouseService, WarehouseService>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<PharmacyDbContext>();

                var seeder = new DbSeeder();

                seeder.SeedAll(context);
            }

            app.Run();
        }
    }
}