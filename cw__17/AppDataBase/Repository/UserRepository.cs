using cw__17.Models.Contract.UserContract;
using cw__17.Models.Entities;

namespace cw__17.AppDataBase.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository()
        {
            _context = new AppDbContext();
        }

        public void Add(User user)
        {
            var creatUser = _context.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
          var user = _context.Users.FirstOrDefault(x => x.Id == id);
            _context.Remove(user);
            _context.SaveChanges();
        }

        public User Get(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public List<User> GetAll()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public User GetByUserName(string userName)
        {
           var user = _context.Users.FirstOrDefault(x=>x.UserName == userName);
            return user;
        }

        public void Update(int id)
        {
            var update = _context.Users.FirstOrDefault(_x => _x.Id == id);
            update = new User()
            {
                FirstName = update.FirstName,
                LastName = update.LastName,
                UserName = update.UserName,
                Password = update.Password,

            };
            _context.SaveChanges();
        }

       
    }
}
