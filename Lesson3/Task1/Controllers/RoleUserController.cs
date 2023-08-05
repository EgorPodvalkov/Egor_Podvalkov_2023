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

        public IActionResult Index()
        {
            var username = HttpContext.Request.Cookies["username"];
            var password = HttpContext.Request.Cookies["password"];

            if (username == null || password == null || !_db.CheckUser(username, password) )
            {
                return RedirectToAction("Index", "Login");
            }

            var user = _db.GetUserByName(username);

            return View(user);
        }
    }
}
