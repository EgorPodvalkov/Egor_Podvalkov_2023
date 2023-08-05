using Task1.Models;

namespace Task1.Database
{
    public interface IDatabaseService
    {
        /// <summary>
        /// Checks if database contains following user with following password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>True if database contains user</returns>
        bool CheckUser(string username, string password);

        /// <summary>
        /// Gives user with following name from database
        /// </summary>
        /// <param name="username"></param>
        /// <returns>User if user is in database, null if not</returns>
        User? GetUserByName(string username);
    }
}
