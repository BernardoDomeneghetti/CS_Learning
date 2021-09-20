using System.ComponentModel.DataAnnotations;

namespace CasaDoCodigo.Models.Entities
{
    public class Produto : BaseModel
    {
        public Produto()
        {

        }

        [Required]
        public int Codigo { get; private set; }
        [Required]
        public string Nome { get; private set; }
        [Required]
        public decimal Preco { get; private set; }

        public Produto(int codigo, string nome, decimal preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}
