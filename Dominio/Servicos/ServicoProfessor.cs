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
    public class ServicoProfessor : IServicoProfessor
    {
        private readonly IRepositorioProfessor _repositorioProfessor;

        public ServicoProfessor(IRepositorioProfessor repositorioProfessor)
        {
            _repositorioProfessor = repositorioProfessor;
        }

        public ResponseBase Adicionar(ProfessorRequest request)
        {
            if (request == null)
            {
                throw new NotImplementedException();
            }

            if (request.Id > 0) return Atualizar(request);

            var entidade = new Professor(request.Nome, request.DataNascimento, request.Salario, true);
            _repositorioProfessor.Adicionar(entidade);
            _repositorioProfessor.SaveChanges();

            return new ResponseBase("Gravado com Sucesso!", entidade.Id);
        }

        public ResponseBase Atualizar(ProfessorRequest request)
        {
            var entidade = _repositorioProfessor.ObterPorId(request.Id);
            entidade.Atualizar(request.Nome, request.DataNascimento, request.Salario, true);
            _repositorioProfessor.Editar(entidade);

            return new ResponseBase("Alterado com Sucesso!", entidade.Id);
        }

        public ResponseBase Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProfessorResponse> Listar()
        {
            return _repositorioProfessor.Listar().ToList().ToMap<Professor, ProfessorResponse>();
        }
    }
}

