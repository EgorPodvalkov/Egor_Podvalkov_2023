using Task1.Models;

namespace Task1.Database
{
    public class Database : IDatabaseService
    {
        private readonly IEnumerable<UserModel> _users;

        /// <summary>
        /// Creates emulation of empty database
        /// </summary>
        public Database()
        {
            _users = new List<UserModel>() 
            {
                new UserModel()
                {
                    UserID = 1,
                    UserName = "Test",
                    Password = "Test",
                    IsAdmin = false,
                },
                new UserModel()
                {
                    UserID = 2,
                    UserName = "FakeAdmin",
                    Password = "admin",
                    IsAdmin = false,
                },
                new UserModel()
                {
                    UserID = 2,
                    UserName = "RealAdmin",
                    Password = "admin",
                    IsAdmin = true,
                },
                new UserModel()
                {
                    UserID = 3,
                    UserName = "a",
                    Password = "a",
                    IsAdmin = false,
                },
            };
        }
        
        public bool CheckUser(string username, string password) 
        { 
            return _users
                .Where(x => 
                    x.UserName == username 
                    && x.Password == password)
                .Any();
        }
        
        public UserModel? GetUserByName(string username)
        {
            return _users.FirstOrDefault(x => x.UserName == username);
        }
    }
}
