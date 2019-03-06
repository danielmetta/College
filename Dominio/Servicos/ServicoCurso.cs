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
    public class ServicoCurso : IServicoCurso
    {
        private readonly IRepositorioCurso _repositorioCurso;

        public ServicoCurso(IRepositorioCurso repositorioCurso)
        {
            _repositorioCurso = repositorioCurso;
        }

        public ResponseBase Adicionar(CursoRequest request)
        {
            if (request == null)
            {
                throw new NotImplementedException();
            }

            if (request.Id > 0) return Atualizar(request);

            var entidade = new Curso(request.Nome, true);
            _repositorioCurso.Adicionar(entidade);
            _repositorioCurso.SaveChanges();

            return new ResponseBase("Gravado com Sucesso!", entidade.Id);
        }

        public ResponseBase Atualizar(CursoRequest request)
        {
            var entidade = _repositorioCurso.ObterPorId(request.Id);
            entidade.Atualizar(request.Nome, true);
            _repositorioCurso.Editar(entidade);

            return new ResponseBase("Alterado com Sucesso!", entidade.Id);
        }

        public ResponseBase Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CursoResponse> Listar()
        {
            return _repositorioCurso.Listar().ToList().ToMap<Curso, CursoResponse>();
        }

        public List<Dash> Dashboard()
        {
            var lista = new List<Dash>();
            var cursos = _repositorioCurso.Listar(x => x.Disciplinas.Select(y => y.DisciplinaAlunos));
            foreach (var curso in cursos)
            {
                var retorno = new Dash
                {
                    NomeCurso = curso.Nome,
                    QtdDisciplinas = curso.Disciplinas.Count
                };

                foreach (var disciplina in curso.Disciplinas)
                {
                    var alunos = disciplina.DisciplinaAlunos.Count(x => x.Disciplina.CursoId == disciplina.CursoId);
                    retorno.QtdAlunos += alunos;
                    retorno.SumNota += alunos > 0 ? disciplina.DisciplinaAlunos.Sum(x => x.Nota) / alunos : 0;
                }

                retorno.MediaNota = retorno.QtdDisciplinas > 0 ? retorno.SumNota / retorno.QtdDisciplinas : 0;
                lista.Add(retorno);
            }

            return lista;
        }
    }

    public class Dash
    {
        public string NomeCurso { get; set; }
        public int QtdDisciplinas { get; set; }
        public int QtdAlunos { get; set; }
        public decimal MediaNota { get; set; }
        public decimal SumNota { get; set; }
    }
}
