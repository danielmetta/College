using Dominio.Entidades.Base;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Disciplina : EntidadeBase
    {
        public Disciplina()
        {

        }

        public Disciplina(string nome, int cursoId, int professorId, bool ativo)
        {
            this.Nome = nome;
            this.Ativo = Ativo;
            this.CursoId = cursoId;
            this.ProfessorId = professorId;
        }

        public void Atualizar(string nome, int cursoId, int professorId, bool ativo)
        {
            this.Nome = nome;
            this.Ativo = Ativo;
            this.CursoId = cursoId;
            this.ProfessorId = professorId;
        }

        public string Nome { get; set; }

        public int ProfessorId { get; set; }
        public virtual Professor Professor { get; set; }

        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }

        public ICollection<DisciplinaAluno> DisciplinaAlunos { get; set; }

    }
}
