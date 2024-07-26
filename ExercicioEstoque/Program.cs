//Fazer um programa para ler os dados de um produto em estoque (nome, preço e
//quantidade no estoque). Em seguida:
//• Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no
//estoque)
//• Realizar uma entrada no estoque e mostrar novamente os dados do produto
//• Realizar uma saída no estoque e mostrar novamente os dados do produto
using ExercicioEstoque;
using System;
using System.Globalization;
using System.Net.WebSockets;

namespace MedidaDosLadosDeDoisTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto n1 = new Produto();

            Console.WriteLine("Entre com os dados do produto \n");
            Console.Write("Nome: ");
            n1.Nome = Console.ReadLine();
            Console.Write("Preço: R$");
            n1.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            n1.Qtd = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Estoque");
            Console.WriteLine(n1);
            Console.WriteLine("\n");

            Console.WriteLine("[1] Para adicionar produto: ");
            Console.Write("[2] Para Remover produto: ");
            int escolha = int.Parse((string)Console.ReadLine());

            while (escolha < 1 || escolha > 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Opção invalida!!!");
                Console.WriteLine("[1] Para adicionar produto: ");
                Console.Write("[2] Para Remover produto: ");
                escolha = int.Parse((string)Console.ReadLine());
            }
            if (escolha == 1)
            {
                Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
                int qtd = int.Parse(Console.ReadLine());
                n1.AdicionarProduto(qtd);
                Console.WriteLine(n1);
                Console.WriteLine("\n");
            }
            else
            {
                Console.Write("Digite o número de produtos a ser removido ao estoque: ");
                int qtd = int.Parse(Console.ReadLine());
                n1.ExcluirProduto(qtd);
                Console.WriteLine(n1);
            }

        }
    }
}
