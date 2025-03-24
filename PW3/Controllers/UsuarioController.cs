using Microsoft.AspNetCore.Mvc;

namespace PW3.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
