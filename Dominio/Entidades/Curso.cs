using Dominio.Entidades.Base;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Curso : EntidadeBase
    {
        public Curso()
        {

        }

        public Curso(string nome, bool ativo)
        {
            this.Nome = nome;
            this.Ativo = ativo;
        }

        public void Atualizar(string nome, bool ativo)
        {
            this.Nome = nome;
            this.Ativo = ativo;
        }

        public string Nome { get; private set; }
        public ICollection<Disciplina> Disciplinas { get; set; }
    }
}
