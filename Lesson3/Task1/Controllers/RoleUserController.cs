using Microsoft.AspNetCore.Mvc;
using Task1.Database;

namespace Task1.Controllers
{
    public class RoleUserController : Controller
    {
        private readonly IDatabaseService _db;

        public RoleUserController(IDatabaseService db)
        {
            _db = db;
        }

        public IActionResult Index(string UserName, string Password)
        {
            if (UserName == null || Password == null || !_db.CheckUser(UserName, Password) )
            {
                return RedirectToAction("Index", "Login");
            }

            var user = _db.GetUserByName(UserName);

            return View(user);
        }
    }
}
