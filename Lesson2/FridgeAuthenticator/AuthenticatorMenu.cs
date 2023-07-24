using FridgeAuthenticator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeAuthenticator
{
    public class AuthenticatorMenu
    {
        private readonly IRegistrator _fridgeRegistrator;

        public AuthenticatorMenu(IRegistrator fridgeRegistrator)
        {
            _fridgeRegistrator = fridgeRegistrator;
        }

        public void StartApp(bool once = false)
        {
            while (true)
            {
                var operation = AskOperation();

                switch (operation)
                {
                    // Getting
                    case 1:
                        GetCase();
                        break;

                    // Putting
                    case 2:
                        PutCase();
                        break;

                    // Removing
                    case 3:
                        RemoveCase();
                        break;

                    // Bad responce
                    default:
                        Console.WriteLine("I'm not sure what should happen.\n");
                        break;
                }

                if (once) break;
            }
        }

        #region Asking
        private int AskOperation()
        {
            Console.Write("Enter 1 to get, 2 to put or 3 to remove item from fridge: ");
            int.TryParse(Console.ReadLine(), out var operation);
            return operation;
        }

        private string AskName()
        {
            Console.Write("Firstly, tell me your name: ");
            return Console.ReadLine() ?? "";
        }

        private string AskItem()
        {
            Console.Write("So, what is your item name: ");
            return Console.ReadLine() ?? "";
        }
        #endregion

        #region Getting
        private void GetCase()
        {
            var name = AskName();
            var item = AskItem();

            TryGet(name, item);
        }

        private void TryGet(string name, string item)
        {
            if (_fridgeRegistrator.CheckRegistration(item, name))
                Console.WriteLine($"Success! You can take your {item}, {name}.\n");
            else
                Console.WriteLine($"No way, this {item} isn`t yours, {name}.\n");
        }
        #endregion

        #region Putting
        private void PutCase()
        {
            var name = AskName();
            var item = AskItem();

            TryPut(name, item);
        }

        private void TryPut(string name, string item)
        {
            _fridgeRegistrator.AddRegistration(item, name);

            Console.WriteLine($"You have put your {item} in the fridge, {name}.\n");
        }
        #endregion

        #region Removing
        private void RemoveCase()
        {
            var item = AskItem();

            TryRemove(item);
        }

        private void TryRemove(string item)
        {
            if (_fridgeRegistrator.RemoveRegistration(item))
                Console.WriteLine($"The {item} successfully removed from the fridge.\n");
            else
                Console.WriteLine("Something wrong with removing :(\n");
        }
        #endregion
    }
}
