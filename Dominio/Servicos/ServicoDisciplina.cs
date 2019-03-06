using Dominio.Argumentos;
using Dominio.Argumentos.Base;
using Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;
using Dominio.Util;

namespace Dominio.Servicos
{
    public class ServicoDisciplina : IServicoDisciplina
    {
        private readonly IRepositorioDisciplina _repositorioDisciplina;
        private readonly IRepositorioDisciplinaAluno _repositorioDisciplinaAluno;

        public ServicoDisciplina(IRepositorioDisciplina repositorioDisciplina, IRepositorioDisciplinaAluno repositorioDisciplinaAluno)
        {
            _repositorioDisciplina = repositorioDisciplina;
            _repositorioDisciplinaAluno = repositorioDisciplinaAluno;
        }

        public ResponseBase Adicionar(DisciplinaRequest request)
        {
            if (request == null)
            {
                throw new NotImplementedException();
            }

            if (request.Id > 0) return Atualizar(request);

            var entidade = new Disciplina(request.Nome, request.CursoId, request.ProfessorId, true);
            _repositorioDisciplina.Adicionar(entidade);
            _repositorioDisciplina.SaveChanges();

            return new ResponseBase("Gravado com Sucesso!", entidade.Id);
        }

        public ResponseBase Atualizar(DisciplinaRequest request)
        {
            var entidade = _repositorioDisciplina.ObterPorId(request.Id);
            entidade.Atualizar(request.Nome, request.CursoId, request.ProfessorId, true);
            _repositorioDisciplina.Editar(entidade);

            return new ResponseBase("Alterado com Sucesso!", entidade.Id);
        }

        public ResponseBase Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DisciplinaResponse> Listar()
        {
            return _repositorioDisciplina.Listar(x => x.Curso, x => x.Professor).ToList().ToMap<Disciplina, DisciplinaResponse>();
        }

        public IEnumerable<Disciplina2Response> ListarDisciplinas()
        {
            var retorno = _repositorioDisciplina.Listar(x => x.Curso, x => x.Professor).ToList()
                .ToMap<Disciplina, Disciplina2Response>();

            foreach (var item in retorno)
            {
                item.DisciplinaAlunos = _repositorioDisciplinaAluno.ListarPor(x => x.DisciplinaId == item.Id, x=>x.Aluno).ToList().ToMap<DisciplinaAluno, DisciplinaAlunoResponse>();
            }

            return retorno;
        }
    }
}
