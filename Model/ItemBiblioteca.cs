using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class ItemBiblioteca
    {
        public  int id { get; set; }
        public  string? titulo { get; set; }
        public string? autor { get; set; }
        public int anoPublicao { get; set; }

        Random randNum = new Random();

        public ItemBiblioteca()
        {
            
        }

        public ItemBiblioteca(string titulo, string autor, int anoPublicacao)
        {
            id = randNum.Next(100);
            this.autor = autor;
            this.titulo = titulo;
            this.anoPublicao = anoPublicacao;
            
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine("ID: {0}", this.id);
            Console.WriteLine("Autor: {0}", this.autor);
            Console.WriteLine("Titulo: {0}", this.titulo);
            Console.WriteLine("Ano Publicao: {0}", this.anoPublicao);
        }


    }
}
