using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (!Nome.Any())
            {
                AdicionarCritica("Nome tem que ser preenchido.");
            }
            if (!Descricao.Any())
            {
                AdicionarCritica("Descrição precisa ser preenchida.");
            }
            
        }
    }
}
