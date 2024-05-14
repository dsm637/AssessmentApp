using Microsoft.Extensions.DependencyInjection;

namespace AssessmentApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddHttpClient();

            //builder.Services.AddTransient<INpsApiClient>(sp => new NpsApiClient(
            //    sp.GetRequiredService<IHttpClientFactory>().CreateClient(),
            //    sp.GetRequiredService<ILogger<NpsApiClient>>(),
            //    sp.GetRequiredService<IConfiguration>()
            //    ));
            //builder.Services.AddTransient<IGeoLocationApiClient>(sp => new GeoLocationApiClient(
            //    sp.GetRequiredService<IHttpClientFactory>().CreateClient(),
            //    sp.GetRequiredService<ILogger<GeoLocationApiClient>>(),
            //    sp.GetRequiredService<IConfiguration>()
            //    ));
            builder.Services.AddTransient<IGeoLocationApiClient>(sp => new FakeGeoLocClient());
            builder.Services.AddTransient<INpsApiClient>(sp => new FakeNpsClient());

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
