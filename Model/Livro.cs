using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Livro : ItemBiblioteca
    {
        public static bool disponivel { get; set; }

        public Livro()
        {
            
        }
        public Livro(string titulo, string autor, int anoPublicacao)
            : base(titulo, autor, anoPublicacao){

            disponivel = false;
        }


        public void EmprestarLivro()
        {
            if (disponivel)
            {
                disponivel = false;
                Console.WriteLine($"O livro '{titulo}' foi emprestado.");
            }
            else
            {
                Console.WriteLine($"O livro '{titulo}' não está disponível para empréstimo.");
            }
        }

        public void DevolverLivro()
        {
            if (!disponivel)
            {
                disponivel = true;
                Console.WriteLine($"O livro '{titulo}' foi devolvido.");
            }
            else
            {
                Console.WriteLine($"O livro '{titulo}' não estava emprestado.");
            }
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Disponível: {(disponivel ? "Sim" : "Não")}");
        }


    }
}
