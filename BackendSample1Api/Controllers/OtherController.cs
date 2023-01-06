using Microsoft.AspNetCore.Mvc;

namespace BackendSample1Api.Controllers
{
    public class OtherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
