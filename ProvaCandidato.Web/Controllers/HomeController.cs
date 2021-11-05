using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

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
  }
}