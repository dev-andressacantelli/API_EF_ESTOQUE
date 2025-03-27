using System.ComponentModel.DataAnnotations;

namespace pjt.apc.estoque.domain.Models
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public decimal Valor { get; set; }
        public string Genero { get; set; }
        public string Tamanho { get; set; }
        public string Cor { get; set; }
    }
}