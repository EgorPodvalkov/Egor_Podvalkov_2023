using FridgeAuthenticator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeAuthenticator.Services
{
    public class FridgeRegistrator : IRegistrator
    {
        /// <summary>
        /// Contains items with their owners` names
        /// </summary>
        private Dictionary<string, string> _fridge;

        public FridgeRegistrator(Dictionary<string, string> fridge) 
        {
            _fridge = fridge;
        }

        public void AddRegistration(string item, string userName)
        {
            _fridge.Add(item.ToLower(), userName.ToLower());
        }

        public bool CheckRegistration(string item, string userName)
        {
            return _fridge.ContainsKey(item.ToLower()) && _fridge[item.ToLower()] == userName.ToLower();
        }

        public bool RemoveRegistration(string item)
        {
            return _fridge.Remove(item.ToLower());
        }
    }
}
