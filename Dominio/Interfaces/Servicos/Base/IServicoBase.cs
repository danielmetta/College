using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Servicos.Base
{
    public interface IServicoBase<in TRequest, out TResponse> 
    {
        TResponse Adicionar(TRequest request);
        TResponse Atualizar(TRequest request);
    }
}
