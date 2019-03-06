using System;
using System.Web.Mvc;
using Dominio.Argumentos;
using Dominio.Interfaces.Servicos;

namespace College.Controllers
{
    public class AlunoController : Controller, ICrudController<AlunoRequest>
    {
        private readonly IServicoAluno _servicoAluno;

        public AlunoController(IServicoAluno servicoAluno)
        {
            _servicoAluno = servicoAluno;
        }

        public JsonResult Get()
        {
            try
            {
                var retorno = _servicoAluno.Listar();
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public JsonResult Post(AlunoRequest request)
        {
            try
            {
                var retorno = _servicoAluno.Adicionar(request);
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public JsonResult Put(AlunoRequest request)
        {
            try
            {
                var retorno = _servicoAluno.Atualizar(request);
                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}