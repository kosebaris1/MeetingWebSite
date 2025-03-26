using MeetingWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeetingWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
           ViewBag.Sonuc= hour > 12 ? "iyi günler" : "Günaydýn";
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            MeetingInfo meetingInfo=new MeetingInfo()
            {
                Id = 1,
                Location="Istanbul",
                Date= new DateTime(2024,01,20,19,0,0),
                NumberOfPeople=UserCount,
            };

            return View( meetingInfo ); //String bilgi olmadýðý için model:meetingInfo dememize gerek yok
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
