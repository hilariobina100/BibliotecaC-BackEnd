using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Revista:ItemBiblioteca
    {
        public int edicao { get; set; }

        public Revista(string titulo, string autor, int anoPublicacao, int edicao)
        : base(titulo, autor, anoPublicacao)
        {
            this.edicao = edicao;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Edição: {edicao}");
        }

    }
}
