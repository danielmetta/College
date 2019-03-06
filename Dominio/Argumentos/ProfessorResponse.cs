using Dominio.Argumentos.Base;
using System;

namespace Dominio.Argumentos
{
    public class ProfessorResponse : ArgumentoBase
    {
        public string Nome { get;  set; }
        public string DataNascimento { get;  set; }
        public decimal Salario { get;  set; }
    }
}
