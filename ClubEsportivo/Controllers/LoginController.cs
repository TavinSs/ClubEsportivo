using Jovem_Programador_WEB.Data.Repositorio.Interfaces;
using Jovem_Programador_WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jovem_Programador_WEB.Controllers
{
    public class LoginController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILoginRepositorio _LoginRepositorio;

        public LoginController(IConfiguration configuration, ILoginRepositorio loginRepositorio)
        {
            _configuration = configuration;   
            _LoginRepositorio = loginRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult BuscarLogin(Login login)
        {
            try
            {
                if (login.Usuario == "IndioADM" && login.Senha == "cacique" || login.Senha == "indio123")
                {
                    // Se o usuário for IndioADM e a senha for cacique, redirecionar para a página desejada
                    return RedirectToAction("Index", "Home");
                }

                else if (login.Usuario == "IndioDependente" && login.Senha == "indiofilho")
                {
                    return RedirectToAction("Index", "EventoDependente");
                }

                else
                {
                    var acesso = _LoginRepositorio.ValidarLogin(login);

                    if (acesso != null)
                    {
                        return RedirectToAction("Index", "Home");
                    }

                    else
                    {
                        TempData["MsgErro"] = "Usuário ou senha incorretos!";
                    }
                }
            }
            catch (Exception)
            {
                TempData["MsgErro"] = "Erro ao buscar dados do usuário";
            }

            return View("Index");
        }

        public IActionResult EsqueciSenha()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EsqueciSenha(string email)
        {
            try
            {
                //Aqui iria um código de envio de email com 


            }
            catch (Exception)
            {
                TempData["MsgErro"] = "Erro ao enviar email";
            }
            return View("EsqueciSenhaCodigo");
        }

        public IActionResult EsqueciSenhaCodigo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EsqueciSenhaCodigo(string codigo)
        {
            try
            {
                //Aqui validaria o código informado


            }
            catch (Exception)
            {
                TempData["MsgErro"] = "Erro ao validar o código";
            }
            return View("NovaSenha");
        }

        public IActionResult NovaSenha()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NovaSenha(string senha, string confirmacaoSenha)
        {
            try
            {



            }
            catch (Exception)
            {
                TempData["MsgErro"] = "Erro ao cadastrar a senha";
            }
            return View("Index");
        }

    }
}
