using System;
using System.Web.Mvc;
using Dominio.Argumentos;
using Dominio.Interfaces.Servicos;

namespace CollegeAngular.Controllers
{
    public class CursoController : Controller, ICrudController<CursoRequest>
    {
        private readonly IServicoCurso _servicoCurso;

        public CursoController(IServicoCurso servicoCurso)
        {
            _servicoCurso = servicoCurso;
        }

        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                var retorno = _servicoCurso.Listar();
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost]
        public JsonResult Post(CursoRequest request)
        {
            try
            {
                var retorno = _servicoCurso.Adicionar(request);
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public JsonResult Put(CursoRequest request)
        {
            try
            {
                var retorno = _servicoCurso.Atualizar(request);
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}