using System.Collections.Generic;
using Dominio.Argumentos;
using Dominio.Argumentos.Base;
using Dominio.Interfaces.Servicos.Base;

namespace Dominio.Interfaces.Servicos
{
    public interface IServicoDisciplina : IServicoBase<DisciplinaRequest, ResponseBase>
    {
        IEnumerable<DisciplinaResponse> Listar();
        IEnumerable<Disciplina2Response> ListarDisciplinas();
    }
}
