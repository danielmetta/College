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
    public class RepositorioDisciplina : RepositorioBase<Disciplina, int>, IRepositorioDisciplina
    {
        protected readonly CollegeContexto _context;

        public RepositorioDisciplina(CollegeContexto context)
            : base(context)
        {
            _context = context;
        }
    }
}
