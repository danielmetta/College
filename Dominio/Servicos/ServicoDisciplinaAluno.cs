using Dominio.Argumentos;
using Dominio.Argumentos.Base;
using Dominio.Interfaces.Repositorios;
using Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Util;

namespace Dominio.Servicos
{
    public class ServicoDisciplinaAluno : IServicoDisciplinaAluno
    {
        private readonly IRepositorioDisciplinaAluno _repositorioDisciplinaAluno;

        public ServicoDisciplinaAluno(IRepositorioDisciplinaAluno repositorioDisciplinaAluno)
        {
            _repositorioDisciplinaAluno = repositorioDisciplinaAluno;
        }

        public ResponseBase Adicionar(DisciplinaAlunoRequest request)
        {
            if (request == null)
            {
                throw new NotImplementedException();
            }

            if (request.Id > 0) return Atualizar(request);

            var entidade = new DisciplinaAluno(request.DisciplinaId, request.AlunoId, request.Nota);
            _repositorioDisciplinaAluno.Adicionar(entidade);
            _repositorioDisciplinaAluno.SaveChanges();

            return new ResponseBase("Gravado com Sucesso!", entidade.Id);
        }

        public ResponseBase Atualizar(DisciplinaAlunoRequest request)
        {
            var entidade = _repositorioDisciplinaAluno.ObterPorId(request.Id);
            entidade.Atualizar(request.DisciplinaId, request.AlunoId, request.Nota);
            _repositorioDisciplinaAluno.Editar(entidade);

            return new ResponseBase("Alterado com Sucesso!", entidade.Id);
        }

        public ResponseBase Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DisciplinaAlunoResponse> Listar()
        {
            return _repositorioDisciplinaAluno.Listar(x=>x.Disciplina, x=>x.Aluno).ToList().ToMap<DisciplinaAluno, DisciplinaAlunoResponse>();
        }
    }
}
