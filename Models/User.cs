
namespace UserApi.Models
{
    public record User(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Password,
        string Telephone,
        string Username,
        string Role,
        DateTime CreatedAt,
        DateTime ModifiedAt
    );
}