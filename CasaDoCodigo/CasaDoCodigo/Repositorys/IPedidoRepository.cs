using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models.Entities;
using Microsoft.AspNetCore.Http;

namespace CasaDoCodigo.Repositorys
{
    public interface IPedidoRepository: IBaseRepository<Pedido>
    {        
        int GetPedidoId();
    }
}
