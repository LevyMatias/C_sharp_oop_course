/* Aula sobre a estrutura try catch. A instrução try-catch consiste em um bloco try seguido 
 * por uma ou mais cláusulas catch, que especificam os manipuladores para diferentes exceções.
 * https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/try-catch */ 

using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}
