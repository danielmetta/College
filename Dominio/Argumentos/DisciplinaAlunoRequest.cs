using Dominio.Argumentos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Argumentos
{
    public class DisciplinaAlunoRequest : ArgumentoBase
    {
        public int DisciplinaId { get; set; }
        public int AlunoId { get; set; }
        public decimal Nota { get; set; }
    }
}
