using Dominio.Argumentos.Base;
using System;
using System.Collections.Generic;

namespace Dominio.Argumentos
{
    public class AlunoResponse : ArgumentoBase
    {
        public string Nome { get;  set; }
        public string DataNascimento { get;  set; }
        public string Matricula { get;  set; }

        public IEnumerable<DisciplinaAlunoResponse> DisciplinaAlunos { get; set; }
    }
}
