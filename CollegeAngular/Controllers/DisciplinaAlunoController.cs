using System;
using System.Web.Mvc;
using Dominio.Argumentos;
using Dominio.Interfaces.Servicos;

namespace CollegeAngular.Controllers
{
    public class DisciplinaAlunoController : Controller, ICrudController<DisciplinaAlunoRequest>
    {
        private readonly IServicoDisciplinaAluno _servicoDisciplinaAluno;

        public DisciplinaAlunoController(IServicoDisciplinaAluno servicoDisciplinaAluno)
        {
            _servicoDisciplinaAluno = servicoDisciplinaAluno;
        }

        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                var retorno = _servicoDisciplinaAluno.Listar();
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost]
        public JsonResult Post(DisciplinaAlunoRequest request)
        {
            try
            {
                var retorno = _servicoDisciplinaAluno.Adicionar(request);
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public JsonResult Put(DisciplinaAlunoRequest request)
        {
            try
            {
                var retorno = _servicoDisciplinaAluno.Atualizar(request);
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