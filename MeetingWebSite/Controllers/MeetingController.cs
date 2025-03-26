using MeetingWebSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingWebSite.Controllers
{
    public class MeetingController : Controller
    {

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            Repository.CreateUser(model);
            ViewBag.UserCount = Repository.Users.Where(info=>info.WillAttend==true).Count();
            return View("Thanks",model);
        }
        public IActionResult List()
        {
            var users = Repository.Users;   
            return View(users);
        }

        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}
