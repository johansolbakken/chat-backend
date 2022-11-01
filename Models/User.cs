
namespace Chat.Models
{
    public record User(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Password,
        string Telephone,
        DateTime CreatedAt,
        DateTime ModifiedAt
    );
}