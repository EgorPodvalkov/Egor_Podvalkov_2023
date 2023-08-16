using Microsoft.AspNetCore.Mvc;
using Task1.Database;
using Task1.Models;

namespace Task1.Controllers
{
    public class LoginController : Controller
    {
        private readonly IDatabaseService _db;

        public LoginController(IDatabaseService db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(UserValidationModel user)
        {
            // If bad Validation
            if (!ModelState.IsValid)
            {
                return View("Index", user);
            }

            // If no such user in db
            if(!_db.CheckUser(user.UserName, user.Password))
            {
                user.Message = "Bad password or username :(";
                return View("Index", user);

            }
                
            return RedirectToAction("Index", "RoleUser", user);
        }
    }
}
