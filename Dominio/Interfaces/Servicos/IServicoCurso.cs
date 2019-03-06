using System.Collections.Generic;
using Dominio.Argumentos;
using Dominio.Argumentos.Base;
using Dominio.Interfaces.Servicos.Base;
using Dominio.Servicos;

namespace Dominio.Interfaces.Servicos
{
    public interface IServicoCurso : IServicoBase<CursoRequest, ResponseBase>
    {
        IEnumerable<CursoResponse> Listar();
        List<Dash> Dashboard();
    }
}
