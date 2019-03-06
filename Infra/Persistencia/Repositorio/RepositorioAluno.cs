using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;
using Infra.Persistencia.Repositorio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistencia.Repositorio
{
    public class RepositorioAluno : RepositorioBase<Aluno, int>, IRepositorioAluno
    {
        protected readonly CollegeContexto _context;

        public RepositorioAluno(CollegeContexto context)
            : base(context)
        {
            _context = context;
        }
    }
}
