
using System.Web.Mvc;
using Dominio.Interfaces.Servicos;

namespace CollegeAngular.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServicoCurso _servicoCurso;

        public HomeController(IServicoCurso servicoCurso)
        {
            _servicoCurso = servicoCurso;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Dashboard()
        {
            var retorno = _servicoCurso.Dashboard();
            return Json(retorno, JsonRequestBehavior.AllowGet);
        }

    }
}