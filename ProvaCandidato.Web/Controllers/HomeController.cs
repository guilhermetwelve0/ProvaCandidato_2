using System.Web.Mvc;

namespace ProvaCandidato.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Empresa()
        {
            string ParametrizeoNomedaEmpresaAqui = System.Configuration.ConfigurationManager.AppSettings["NomeEmpresa"];

            return View();
        }
        public
    }
}