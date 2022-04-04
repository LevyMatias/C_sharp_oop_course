/* Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas
válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
possui a maior área.*/
using System;

namespace areaTrianguloXeY
{
    class Program
    {
        static void Main(string[] args)
        {   
            Triangulo x, y, maior;
            x = new Triangulo();
            y = new Triangulo();
            maior = new Triangulo();

            Console.WriteLine("Entre com as medidas de X: ");
            string[] trianguloX = Console.ReadLine().Split(' ');

            x.A = double.Parse(trianguloX[0]);
            x.B= double.Parse(trianguloX[1]);
            x.C= double.Parse(trianguloX[2]);

            Console.WriteLine("Entre com as medidas de Y: ");

            string[] trianguloY = Console.ReadLine().Split(' ');

            y.A= double.Parse(trianguloY[0]);
            y.B= double.Parse(trianguloY[1]);
            y.C= double.Parse(trianguloY[2]);

            double areaTrianguloX = x.Area();
            double areaTrianguloY = y.Area();
            
            Console.WriteLine("Area de X = {0}",areaTrianguloX.ToString("N6"));
            Console.WriteLine("Area de Y = {0}",areaTrianguloY.ToString("N6"));

             if(areaTrianguloX > areaTrianguloY)
             {
                 Console.WriteLine("Maior area: {0}",areaTrianguloX.ToString("N6"));
             }
             else
             {
                 Console.WriteLine("Maior area: {0}",areaTrianguloY.ToString("N6"));
            
             }
        }
    }
}
