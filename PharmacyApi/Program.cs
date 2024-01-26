using Microsoft.EntityFrameworkCore;
using PharmacyApi.Data;
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

            #region DbContext

            builder.Services.AddDbContextPool<PharmacyDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaulConnectinon"));
            });

            builder.Services.AddScoped<TenantRequest>();

            builder.Services.AddScoped<PharmacyDbContext>();

            builder.Services.AddScoped(serviceProvider =>
            {
                var pooledFactory = serviceProvider.GetRequiredService<PharmacyDbContextFactory>();
                return pooledFactory.CreateDbContext();
            });
            #endregion

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

            app.Run();
        }
    }
}