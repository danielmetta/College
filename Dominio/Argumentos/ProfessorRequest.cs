using Dominio.Argumentos.Base;
using System;

namespace Dominio.Argumentos
{
    public class ProfessorRequest : ArgumentoBase
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }
    }
}
