using Microsoft.AspNetCore.Mvc;

namespace Jovem_Programador_WEB.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
    }
}
