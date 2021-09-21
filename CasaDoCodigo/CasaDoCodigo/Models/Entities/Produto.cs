using System.ComponentModel.DataAnnotations;

namespace CasaDoCodigo.Models.Entities
{
    public class Produto : BaseModel
    {
        public Produto()
        {

        }

        [Required]
        public int Codigo { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public decimal Preco { get; set; }

        public Produto(int codigo, string nome, decimal preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}
