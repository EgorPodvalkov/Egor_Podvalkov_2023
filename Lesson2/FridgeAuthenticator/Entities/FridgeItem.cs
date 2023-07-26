using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeAuthenticator.Entities
{
    public class FridgeItem
    {
        /// <summary>
        /// Name of the item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name of the item`s onwer
        /// </summary>
        public string OwnerName { get; set; }

        public FridgeItem(string name, string ownerName)
        {
            Name = name;
            OwnerName = ownerName;
        }
    }
}
