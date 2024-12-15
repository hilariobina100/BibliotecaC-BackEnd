using Biblioteca.Model;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

public class Program
{
    
    public static void Main(String []args)
    {
        Livro livro;
        bool continuar = true;
       
        
        
        while (continuar)
        {
            Console.Clear();
            ExibirMenu();
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarLivro();
                    break;
                
                case "2":
                    AdicionarRevista();
                    break;
                
                case "3":
                    Console.WriteLine("Lista de Itens:");
                    Biblioteca.Model.Biblioteca.ListarItens();
                    
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "4":
                    Console.Clear();
                    Console.Write("Digite o título para buscar: ");
                    string tituloBusca = Console.ReadLine();
                    Biblioteca.Model.Biblioteca.BuscarPorTitulo(tituloBusca);
                    
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                
                case "5":
                    Console.Clear();
                    Console.Write("Digite o autor para buscar: ");
                    string autorBusca = Console.ReadLine();
                    Biblioteca.Model.Biblioteca.BuscarPorAutor(autorBusca);
                    
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                
                case "6":
                    Console.Clear();
                    livro.EmprestarLivro();

                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                
                case "7":
                    Console.Clear();
                    livro.DevolverLivro();
                    break;
                
                case "8":
                    continuar = false;
                    break;
                
                default:
                    Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    break;

            }

        }

        static void ExibirMenu()
        {
            Console.Write("Escolha uma opção: ");
            Console.WriteLine("Menu de Gerenciamento:");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Adicionar Revista");
            Console.WriteLine("3. Listar Itens");
            Console.WriteLine("4. Buscar por Título");
            Console.WriteLine("5. Buscar por Autor");
            Console.WriteLine("6. Emprestar Livro");
            Console.WriteLine("7. Devolver Livro");
            Console.WriteLine("8. Sair");
        }

        static void AdicionarLivro()
        {
            Console.Clear();
            Console.WriteLine("Adicionar Livro");

            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Console.Write("Ano de publicação: ");
            int anoPublicacao = int.Parse(Console.ReadLine());

            Biblioteca.Model.Biblioteca.AdicionarItem(new Livro(titulo, autor, anoPublicacao));
            Console.WriteLine("Livro adicionado com sucesso! Pressione qualquer tecla para continuar...");
            Console.ReadKey(); ;
        }

        static void AdicionarRevista()
        {
            Console.Clear();
            Console.WriteLine("Adicionar Revista");

            Console.Write("Título: ");
            string titulo1 = Console.ReadLine();

            Console.Write("Autor: ");
            string autor1 = Console.ReadLine();

            Console.Write("Ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Número da edição: ");
            int edicao = int.Parse(Console.ReadLine());

            Biblioteca.Model.Biblioteca.AdicionarItem(new Revista(titulo1, autor1, ano, edicao));
            Console.WriteLine("Revista adicionada com sucesso! Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

    }

}
