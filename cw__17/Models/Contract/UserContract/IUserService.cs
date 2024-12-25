using cw__17.Models.Entities;

namespace cw__17.Models.Contract.UserContract
{
    public interface IUserService
    {
        public void AddUser(User user);
        public void DeleteUser(int id);
        public User GetUser(int id);
        public void Update(int id);
        public bool Login(string userName,string password);
        public bool Register (string firstName,string lastName,string userName,string Password);
        public List<User> GetUsers();
    }
}
