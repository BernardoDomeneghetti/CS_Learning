using CasaDoCodigo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Repositorys;
using CasaDoCodigo.Models.Responses;
using CasaDoCodigo.Models.Entities;

namespace CasaDoCodigo.Services
{
    public interface IPedidoService
    {
        RepositoryListResponse<Pedido> ListProducts();
        RepositoryGetInstanceByID<Pedido> GetPedido(int IdPedido);
    }
}
