using Dominio.Argumentos.Base;
using System;

namespace Dominio.Argumentos
{
    public class AlunoRequest : ArgumentoBase
    {
        public string Nome { get;  set; }
        public DateTime DataNascimento { get;  set; }
        public string Matricula { get;  set; }
    }
}
