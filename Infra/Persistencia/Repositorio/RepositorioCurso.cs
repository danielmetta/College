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
    public class RepositorioCurso : RepositorioBase<Curso, int>, IRepositorioCurso
    {
        protected readonly CollegeContexto _context;

        public RepositorioCurso(CollegeContexto context)
            : base(context)
        {
            _context = context;
        }
    }
}
