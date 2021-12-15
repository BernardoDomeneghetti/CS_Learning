using CasaDoCodigo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
    public class CartViewModel
    {
        public IList<ItemPedido> Itens { get; }

        public CartViewModel(IList<ItemPedido> itens)
        {
            Itens = itens;
        }

        public double Total => Itens.Sum(i => i.Quantidade * (double)i.PrecoUnitario);
    }
}
