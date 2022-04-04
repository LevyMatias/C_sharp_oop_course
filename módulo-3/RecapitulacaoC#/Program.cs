using System;
using System.Globalization;

namespace RecapitulacaoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program exemplos = new Program();

            Exemplo_1();
            Console.WriteLine();
            Exemplo_2();
            Console.WriteLine();
            Exemplo_3();
            Console.WriteLine();
            //formula de bhaskara
            FormulaBhaskara();
            Console.WriteLine();

            // EntradaDeDados();
            // Console.WriteLine();

            // EntradaDeDados_2();
            // Console.WriteLine();

            ExpressaoBooleana();
            Console.WriteLine();

            ExpressaoLogica();

        }

        // Conversões implicitas e Castings
        static void Exemplo_1() // conversão implicita
        {
            Console.WriteLine("Exemplo - 1");
            float x = 5.1f;

            double y = x;

            Console.WriteLine(y);
            Console.WriteLine();

            Console.WriteLine("Casting com o mesmo exemplo:");

            double z = 5.1;
            float w = (float)z; // conversão explicita (casting)

            Console.WriteLine(w);

        }

        static void Exemplo_2()
        {
            Console.WriteLine("Exemplo - 2");

            double a;
            int b;

            a = 5.1;
            b = (int)a;

            Console.WriteLine(b);
        }

        static void Exemplo_3()
        {
            Console.WriteLine("Exemplo - 3");

            int a = 5;
            int b = 2;

            double resultado = (double)a / b;

            Console.WriteLine(resultado);
        }

        // precedencia dos operadores aritméticos
        static void FormulaBhaskara()
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8.0;
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }

        // Entrada de dados Exemplos

        static void EntradaDeDados()
        {
            string frase = Console.ReadLine();

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        /* Ler um nome (única palavra), sexo (caractere F ou M), idade (inteiro) e altura (double) na mesma linha, 
        armazenando-os em quatro variáveis com os devidos tipos*/
        static void EntradaDeDados_2()
        {
            int a = int.Parse(Console.ReadLine());
            char letra = char.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            string[] v = Console.ReadLine().Split(' ');
            string nome = v[0];
            char caracter = char.Parse(v[1]);
            int idade = int.Parse(v[2]);
            double altura = double.Parse(v[3]);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(a);
            Console.WriteLine(letra);
            Console.WriteLine(a.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(caracter);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }

        // Operadores relacionais > < >= <= == !=
        static void ExpressaoBooleana()
        {
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
        }

        // Operadores lógicos: !, &&, ||
        static void ExpressaoLogica()
        {
            bool c1 = 2 > 3 || 4 != 5; // true
            bool c2 = !(2 > 3) && 4 != 5; // true

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine("--------------");

            bool c3 = 10 < 5; // false
            bool c4 = c1 || c2 && c3; // true

            Console.WriteLine(c3);
            Console.WriteLine(c4);
        }

        // condicional if else

        static void CondicaoIf()
        {
            int hora = 5;
            Console.WriteLine("Qual a hora atual?");
            Console.WriteLine("Hora atual é: {0}", hora);

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
