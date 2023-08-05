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

        public IActionResult Login()
        {
            string username = this.Request.Form["username"];
            string password = this.Request.Form["Pass"];
            //bool remember = this.Request.Form["remember"] == "on";

            if (_db.CheckUser(username, password))
            {
                Response.Cookies.Append("username", username);
                Response.Cookies.Append("password", password);
                

                return RedirectToAction("Index", "RoleUser");
            }
            
            var err = new MessageModel("Bad password or username :(");
            return View("Index", err);
        }
    }
}
