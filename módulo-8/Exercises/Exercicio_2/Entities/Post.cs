using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public Post()
        {
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        
        public void DeleteComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(Title);
            stringBuilder.Append(Likes);
            stringBuilder.Append(" Likes - ");
            stringBuilder.AppendLine(Moment.ToString("G"));
            stringBuilder.AppendLine(Content);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Comments: ");

            foreach(Comment c in Comments)
            {
                stringBuilder.AppendLine(c.Text);
            }
            return stringBuilder.ToString();
        }
    }
}
