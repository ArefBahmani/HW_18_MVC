using cw__17.Models.Entities;

namespace cw__17.Models.Contract.UserContract
{
    public interface IUserRepository
    {
        public void Add(User user);
        public void Delete(int id);
        public User Get(int id);
        public void Update(int id);
        public List<User> GetAll();
        public User GetByUserName(string userName);
    }
}
