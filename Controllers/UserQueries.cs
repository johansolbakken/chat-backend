using Chat.Models;

namespace Chat.Controllers
{
    public class UserQueries
    {

        public User CreateUser(string FirstName,
                                string LastName,
                                string Email,
                                string Password,
                                string Telephone)
        {
            return new User(Guid.NewGuid(), FirstName, LastName, Email, Password, Telephone, DateTime.Now, DateTime.Now);
        }

        public User CreateEmptyUser()
        {
            return new User(Guid.NewGuid(), "Johan", "Solbakken", "JohanEpost", "Passordet?", "Telefon", DateTime.Now, DateTime.Now);
        }

        public User UserById(Guid id) {
            return new User(id, "Johan", "Solbakken", "JohanEpost", "Passordet?", "Telefon", DateTime.Now, DateTime.Now);
        }

    }
}