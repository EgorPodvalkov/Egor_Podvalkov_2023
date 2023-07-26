using FridgeAuthenticator.Entities;
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
        private Fridge _fridge;

        public FridgeRegistrator(Fridge fridge) 
        {
            _fridge = fridge;
        }

        public void AddRegistration(string item, string userName)
        {
            var entity = new FridgeItem(item.ToLower(), userName.ToLower());

            _fridge.Items.Add(entity);
        }

        public bool CheckRegistration(string item, string userName)
        {
            return _fridge.Items.FirstOrDefault(x => x.Name == item && x.OwnerName == userName) != null;
        }

        public bool RemoveRegistration(string item)
        {
            var entity = _fridge.Items.FirstOrDefault(x => x.Name == item.ToLower());

            if (entity == null) 
                return false;

            return _fridge.Items.Remove(entity);
        }
    }
}
