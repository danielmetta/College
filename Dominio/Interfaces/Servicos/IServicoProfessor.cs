using System.Collections.Generic;
using Dominio.Argumentos;
using Dominio.Argumentos.Base;
using Dominio.Interfaces.Servicos.Base;

namespace Dominio.Interfaces.Servicos
{
    public interface IServicoProfessor : IServicoBase<ProfessorRequest, ResponseBase>
    {
        IEnumerable<ProfessorResponse> Listar();
    }
}
