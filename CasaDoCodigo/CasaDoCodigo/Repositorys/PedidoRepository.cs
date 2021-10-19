using CasaDoCodigo.Models.Entities;
using Microsoft.AspNetCore.Http;
using CasaDoCodigo.Models.Responses;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace CasaDoCodigo.Repositorys
{
    public class PedidoRepository :BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationContext dbContext) : base(dbContext)
        {
            
        }

        public RepositoryGetInstanceByID<Pedido> GetPedidoById(int idPedido)
        {
            try
            {
                return new 
                    RepositoryGetInstanceByID<Pedido>(
                        true, 
                        "Pedido buscado com sucesso!",
                        _dbContext.Set<Pedido>()
                            .Include(p => p.Itens)
                            .ThenInclude(i => i.Produto)
                            .Where(p => p.Id == idPedido).FirstOrDefault()
                    );
            }
            catch(Exception e)
            {
                return new
                    RepositoryGetInstanceByID<Pedido>(
                        true,
                        $@"Falha ao buscar o produto no banco de dados!
                            EXCEPTION TYPE: {e.GetType()}
                            EXCEPTION MESSAGE: {e.Message}",
                        _dbContext.Set<Pedido>()
                            .Include(p => p.Itens)
                            .ThenInclude(i => i.Produto)
                            .Where(p => p.Id == idPedido).FirstOrDefault()
                    );
            }
                
        }
    }
}
