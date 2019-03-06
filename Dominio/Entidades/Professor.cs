using Dominio.Entidades.Base;
using System;

namespace Dominio.Entidades
{
    public class Professor : EntidadeBase
    {
        public Professor()
        {

        }

        public Professor(string nome, DateTime dataNascimento, decimal salario, bool ativo)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Salario = salario;
            this.Ativo = ativo;
        }

        public void Atualizar(string nome, DateTime dataNascimento, decimal salario, bool ativo)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Salario = salario;
            this.Ativo = ativo;
        }

        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public decimal Salario { get; private set; }
    }
}
