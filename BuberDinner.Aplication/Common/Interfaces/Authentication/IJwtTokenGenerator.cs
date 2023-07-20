
namespace BuberDinner.Aplication.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
   string GenerateToken(Guid userId, string firtsName, string lastName);
}
