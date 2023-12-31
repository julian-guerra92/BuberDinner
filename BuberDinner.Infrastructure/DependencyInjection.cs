
using BuberDinner.Aplication.Common.Interfaces.Authentication;
using BuberDinner.Aplication.Common.Interfaces.Services;
using BuberDinner.Infrastructure.Authentication;
using BuberDinner.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Infraestructure;

public static class DependencyInjection
{
   public static IServiceCollection AddInfrastructure(
      this IServiceCollection services,
      ConfigurationManager configuration
   )
   {
      services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
      services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
      services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
      return services;
   }
}
