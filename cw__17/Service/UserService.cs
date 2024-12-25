using cw__17.AppDataBase;
using cw__17.AppDataBase.Repository;
using cw__17.Models.Contract.UserContract;
using cw__17.Models.Entities;

namespace cw__17.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public void AddUser(User user)
        {
            _userRepository.Add(user);
        }

        public void DeleteUser(int id)
        {

            try
            {
                var user = _userRepository.Get(id);
                _userRepository.Delete(user.Id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public User GetUser(int id)
        {
            try
            {
                var user = _userRepository.Get(id);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<User> GetUsers()
        {
            var users = _userRepository.GetAll();
            return users;
        }

        public bool Login(string userName, string password)
        {

            var user = _userRepository.GetByUserName(userName);
            try
            {
                if (user.UserName == userName && user.Password == password)
                {
                    CurrentUser.CurentUser = user;
                    user.IsActive = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");



            }
        }

        public bool Register(string firstName, string lastName, string userName, string Password)
        {
            try
            {
                var userr = _userRepository.GetByUserName(userName);
                if (userr != null)
                {
                    return
                        false;
                }
                var user = new User()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    UserName = userName,
                    Password = Password
                };
                _userRepository.Add(user);
                return true;
                
            }
            
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        public void Update(int id)
        {
            try
            {
                var user = _userRepository.Get(id);
                _userRepository.Update(user.Id);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
