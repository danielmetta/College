using Dominio.Argumentos;
using Dominio.Argumentos.Base;
using Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;
using Dominio.Util;

namespace Dominio.Servicos
{
    public class ServicoAluno : IServicoAluno
    {
        private readonly IRepositorioAluno _repositorioAluno;

        public ServicoAluno(IRepositorioAluno repositorioAluno)
        {
            _repositorioAluno = repositorioAluno;
        }

        public ResponseBase Adicionar(AlunoRequest request)
        {
            if (request == null)
            {
                return null;
            }

            if (request.Id > 0) return Atualizar(request);

            var entidade = new Aluno(request.Nome, request.DataNascimento, request.Matricula, true);
             _repositorioAluno.Adicionar(entidade);
            _repositorioAluno.SaveChanges();

            return new ResponseBase("Gravado com Sucesso!", entidade.Id);
        }

        public ResponseBase Atualizar(AlunoRequest request)
        {
            var entidade = _repositorioAluno.ObterPorId(request.Id);
            entidade.Atualizar(request.Nome, request.DataNascimento, request.Matricula, true);
            _repositorioAluno.Editar(entidade);

            return new ResponseBase("Alterado com Sucesso!", entidade.Id);
        }
        
        public IEnumerable<AlunoResponse> Listar()
        {
            return _repositorioAluno.Listar().ToList().ToMap<Aluno, AlunoResponse>();
        }
    }
}
