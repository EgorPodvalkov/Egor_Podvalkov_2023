using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeAuthenticator.Interfaces
{
    public interface IRegistrator
    {
        /// <summary>
        /// Checks user`s ownship of item
        /// </summary>
        /// <returns>True if user is owner of item</returns>
        bool CheckRegistration(string item, string userName);

        /// <summary>
        /// Adds item to user`s ownship
        /// </summary>
        /// <param name="item"></param>
        /// <param name="user"></param>
        void AddRegistration(string item, string userName);

        /// <summary>
        /// Removes registration
        /// </summary>
        /// <param name="item"></param>
        /// <returns>True if item exist in </returns>
        bool RemoveRegistration(string item);
    }
}
