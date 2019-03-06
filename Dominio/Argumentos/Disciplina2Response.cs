using System.Collections.Generic;
using Dominio.Argumentos.Base;

namespace Dominio.Argumentos
{
    public class Disciplina2Response : ArgumentoBase
    {
        public string Nome { get; set; }

        public int ProfessorId { get; set; }
        public ProfessorResponse Professor { get; set; }

        public int CursoId { get; set; }
        public CursoResponse Curso { get; set; }

        public IEnumerable<DisciplinaAlunoResponse> DisciplinaAlunos { get; set; }
    }
}
