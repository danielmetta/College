using System;
using System.Web.Mvc;
using Dominio.Argumentos;
using Dominio.Interfaces.Servicos;

namespace CollegeAngular.Controllers
{
    public class DisciplinaController : Controller, ICrudController<DisciplinaRequest>
    {
        private readonly IServicoDisciplina _servicoDisciplina;

        public DisciplinaController(IServicoDisciplina servicoDisciplina)
        {
            _servicoDisciplina = servicoDisciplina;
        }

        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                var retorno = _servicoDisciplina.Listar();
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost]
        public JsonResult Post(DisciplinaRequest request)
        {
            try
            {
                var retorno = _servicoDisciplina.Adicionar(request);
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public JsonResult Put(DisciplinaRequest request)
        {
            try
            {
                var retorno = _servicoDisciplina.Atualizar(request);
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet]
        public JsonResult RelatorioDisciplina()
        {
            var retorno = _servicoDisciplina.ListarDisciplinas();
            return Json(retorno, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}