using Bogus;
using pjt.apc.estoque.domain.Models;

namespace pjt.apc.estoque.domain.Bogus
{
    public static class FakeDataProduto
    {
        public static List<Produto> ListaProdutoFake()
        {
            var produtoFaker = new Faker<Produto>("pt_BR")
                .RuleFor(p => p.Nome, f => f.PickRandom(new string[] { "Camisa - Hering", "Calça - Vans", "Casaco - Puma", "Bermuda - Adidas" }))
                .RuleFor(p => p.Estoque, f => f.Random.Number(500))               
                .RuleFor(p => p.Valor, f => f.Random.Decimal(500, 200))
                .RuleFor(p => p.Genero, f => f.PickRandom(new string[] { "masculino", "feminino" }))
                .RuleFor(p => p.Tamanho, f => f.PickRandom(new string[] { "P", "PP", "M", "G", "GG" }))
                .RuleFor(p => p.Cor, f => f.PickRandom(new string[] { "Azul", "Amarelo", "Vermelho", "Verde", "Preto","Branco" }));
            var produto = produtoFaker.Generate(5);
            return produto;         
        }
    }
}