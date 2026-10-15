


using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace HouyarRealState.Infrastructure.Middlewares
{
    public static class ConfigurationServices
    {
        public static IServiceCollection AddPresentationServices(this IServiceCollection services)
        {
            services.AddControllersWithViews()
                .AddXmlSerializerFormatters()
                .ConfigureApiBehaviorOptions(options =>
                {
                    options.SuppressModelStateInvalidFilter = true;

                    options.SuppressInferBindingSourcesForParameters = false;
                }).AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = null;
                    options.JsonSerializerOptions.Encoder = JavaScriptEncoder.Create(UnicodeRanges.All);
                    options.JsonSerializerOptions.PropertyNameCaseInsensitive = false;
                    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;

                    //options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                });



            services.AddSession();

            services.AddEndpointsApiExplorer();


            return services;
        }
    }
}
