using Microsoft.AspNetCore.Mvc;
using MVCFS9.Data;
using MVCFS9.Models;

namespace MVCFS9.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext context;

        public AccountsController(ApplicationDbContext context) 
        
        {
           this.context = context;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {

            context.Users.Add(user);
            context.SaveChanges();
            return RedirectToAction(nameof(Login));
        }
        public IActionResult Login()
        {
            return View(); 
        }
       
        [HttpPost]
        public IActionResult Login(User user)

        {
            var check = context.Users.Where(vali=>vali.UserName == user.UserName && vali.UserPassword == user.UserPassword).ToList();
            if (check.Any())
             {
               
              return RedirectToAction("Index","Students");
            }
            var error = "Wrong user name or Password";
            ViewBag.Error = error;
            return View(user);
         
        }
    }
}
