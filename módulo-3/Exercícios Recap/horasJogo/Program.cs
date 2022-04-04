/* Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/
using System;

namespace horasJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] horas = Console.ReadLine().Split(' ');

            int horaInicio = int.Parse(horas[0]);
            int horaFinal = int.Parse(horas[1]);

            int result = 24 - horaInicio + horaFinal;

            if(horaInicio < horaFinal)
            {
                result = horaFinal - horaInicio;
            }

            Console.WriteLine("O jogo durou {0} horas",result);
        }
    }
}
