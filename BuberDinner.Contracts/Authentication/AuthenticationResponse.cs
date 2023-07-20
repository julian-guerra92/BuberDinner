
namespace BuberDinner.Contracts.Authentication;

public record AuthenticationRepsonse(
   Guid Id,
   string FirstName,
   string LastName,
   string Email,
   string Token);
