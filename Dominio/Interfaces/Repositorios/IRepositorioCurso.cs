using Dominio.Entidades;
using Dominio.Interfaces.Repositorios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorios
{
    public interface IRepositorioCurso : IRepositorioBase<Curso, int>
    {
    }
}
