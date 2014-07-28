using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;
using MvcSample.Web.Services;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
    	  private ITestContext _context;


      	public HomeController(ITestContext context)
      	{
      	    _context = context;
      	}


        public IActionResult Index()
        {
            return View(User());
        }

		    public IActionResult CauseError()
        {
            throw new System.Exception("This has not worked");
        }

        public User User()
        {
            User user = new User()
            {
                Name = _context.GetDate(),
                Address = "My address"
            };

            return user;
        }
    }
}
