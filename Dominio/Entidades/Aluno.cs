using Dominio.Entidades.Base;
using System;

namespace Dominio.Entidades
{
    public class Aluno : EntidadeBase
    {
        public Aluno()
        {

        }

        public Aluno(string nome, DateTime dataNascimento, string matricula, bool ativo)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Matricula = matricula;
            this.Ativo = ativo;
        }

        public void Atualizar(string nome, DateTime dataNascimento, string matricula, bool ativo)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Matricula = matricula;
            this.Ativo = ativo;
            this.DataAlteracao = DateTime.Now;
        }

        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Matricula { get; private set; }
    }
}
