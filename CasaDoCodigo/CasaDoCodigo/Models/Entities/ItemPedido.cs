using System.ComponentModel.DataAnnotations;

namespace CasaDoCodigo.Models.Entities
{
    public class ItemPedido : BaseModel
    {   
        [Required]
        public Pedido Pedido { get; set; }
        [Required]
        public Product Produto { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public decimal PrecoUnitario { get; set; }

        public ItemPedido()
        {

        }

        public ItemPedido(Pedido pedido, Product produto, int quantidade, decimal precoUnitario)
        {
            Pedido = pedido;
            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }
    }
}
