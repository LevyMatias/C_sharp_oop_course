using System;

namespace dadosPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa P1 = new Pessoa();
            Pessoa P2 = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa: ");

            P1.Nome = "Levy";
            P1.Idade = 23;

            Console.WriteLine("Nome: {0}",P1.Nome);
            Console.WriteLine("Idade: {0}",P1.Idade);

            Console.WriteLine("Dados da segunda pessoa: ");

            P2.Nome = "Lucas";
            P2.Idade = 20;

            Console.WriteLine("Nome: {0}",P2.Nome);
            Console.WriteLine("Idade: {0}",P2.Idade);
            if(P1.Idade> P2.Idade)
            
            {
                Console.WriteLine("Pessoa mais velha: {0}",P1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: {0}",P2.Nome);
            }
        }

       
    }
}
