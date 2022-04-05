using Exercicio_2.Entities;
using System;
using static System.Console;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(2022,05,22,14,32,14);
            var comment = new Comment("Muito bom!");
            var comment2 = new Comment("Legal!");

            var post1 = new Post(date,"Viagem","Trabalho",74);

            post1.AddComment(comment);
            post1.AddComment(comment2);

            // second post
            var date2 = new DateTime(2022, 08, 02, 22, 12, 56);
            var comment3 = new Comment("Que familia linda!");
            var comment4 = new Comment("Saudade de voces!");

            var post2 = new Post(date2,"Familia","Reuniao",69);

            post2.AddComment(comment3);
            post2.AddComment(comment4);

            // print post's on screen
            WriteLine(post1);
            WriteLine(post2);  
        }
    }
}
