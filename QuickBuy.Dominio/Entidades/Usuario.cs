using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        /// <summary>
        /// Um usuário pode ter nenhum ou muitos pedidos.
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (!Email.Any())
            {
                AdicionarCritica("E-mail precisa ser preenchido.");
            }
            if (!Senha.Any())
            {
                AdicionarCritica("Senha precisa ser preenchida.");
            }
            if (!Nome.Any())
            {
                AdicionarCritica("Nome precisa ser preenchido.");
            }
            if (!SobreNome.Any())
            {
                AdicionarCritica("Sobrenome precisa ser preenchido.");
            }
        }
    }
}
