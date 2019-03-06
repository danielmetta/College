using System;
using System.Web.Mvc;
using Dominio.Argumentos;
using Dominio.Interfaces.Servicos;

namespace CollegeAngular.Controllers
{
    public class ProfessorController : Controller, ICrudController<ProfessorRequest>
    {
        private readonly IServicoProfessor _servicoProfessor;

        public ProfessorController(IServicoProfessor servicoProfessor)
        {
            _servicoProfessor = servicoProfessor;
        }

        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                var retorno = _servicoProfessor.Listar();
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost]
        public JsonResult Post(ProfessorRequest request)
        {
            try
            {
                var retorno = _servicoProfessor.Adicionar(request);
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public JsonResult Put(ProfessorRequest request)
        {
            try
            {
                var retorno = _servicoProfessor.Atualizar(request);
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