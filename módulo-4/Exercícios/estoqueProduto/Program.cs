using System;

namespace estoqueProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            p.Nome = "Ps5";
            p.Preco = 4999.00;
            p.Quantidade = 8;

            Console.Write("Dados do Produto: "+p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");

            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());

            p.RemoverProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
