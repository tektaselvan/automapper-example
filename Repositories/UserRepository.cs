using automapper_example.Models;

namespace automapper_example.Repositories
{
    public static class UserRepository
    {
        public static List<User> Users { get; } = new List<User>();
    }
}
