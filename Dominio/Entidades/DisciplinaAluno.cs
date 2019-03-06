using Dominio.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
   public class DisciplinaAluno : EntidadeBase
    {
        public DisciplinaAluno()
        {

        }

        public DisciplinaAluno(int disciplinaId, int alunoId, decimal nota)
        {
            this.DisciplinaId = disciplinaId;
            this.AlunoId = alunoId;
            this.Nota = nota;
        }

        public void Atualizar(int disciplinaId, int alunoId, decimal nota)
        {
            this.DisciplinaId = disciplinaId;
            this.AlunoId = alunoId;
            this.Nota = nota;
        }

        public int DisciplinaId { get; set; }
        public virtual Disciplina Disciplina { get; set; }

        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }

        public decimal Nota { get; set; }
    }
}
