using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Biblioteca
    {
        static List<ItemBiblioteca> itens = new List<ItemBiblioteca>();


        public static void AdicionarItem(ItemBiblioteca item)
        {
            itens.Add(item);
            Console.WriteLine($"Ites adicionado à biblioteca.");
        }

        public static void ListarItens()
        {
            if( itens.Count <= 0 )
            {
                Console.WriteLine("A biblioteca está vazia.");
            }
            else
            {
                foreach (var item in itens)
                {
                    item.ExibirDetalhes();
                    Console.WriteLine("--------------------------------------------------");
                }
            }
        }

        public static void BuscarPorTitulo(string titulo)
        {
            for (int i = 0; i < itens.Count; i++)
            {
                if (itens[i].titulo == titulo)
                {
                    itens[i].ExibirDetalhes();
                }
            }
        }

        public static void BuscarPorAutor(string autor)
        {
            for (int i = 0; i < itens.Count; i++)
            {
                if (itens[i].titulo == autor)
                {
                    itens[i].ExibirDetalhes();
                }
            }
        }
    }
}
