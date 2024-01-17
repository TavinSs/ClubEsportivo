using Microsoft.AspNetCore.Mvc;

namespace Jovem_Programador_WEB.Controllers
{
    public class EventoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
