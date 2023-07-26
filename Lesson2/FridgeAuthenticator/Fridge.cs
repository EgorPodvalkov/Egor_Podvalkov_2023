using FridgeAuthenticator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeAuthenticator
{
    public class Fridge
    {
        public List<FridgeItem> Items { get; set; }

        public Fridge() 
        {
            Items = new List<FridgeItem>();
        }
    }
}
