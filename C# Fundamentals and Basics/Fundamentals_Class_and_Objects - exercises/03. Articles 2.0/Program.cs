using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace _02._Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
        public override string ToString()
        {
            //return base.ToString();
            return $"{this.Title} - {this.Content}: {this.Author}";
        }

    }
    class Catalog
    {
        public Catalog()
        {
            this.Articles = new List<Article>();
        }
        public List<Article> Articles { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {


            Catalog catalog = new Catalog();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title, content, author);

                catalog.Articles.Add(article);

            }
            string criteria = Console.ReadLine();
            if(criteria == "title")
            {
                foreach (Article article in catalog.Articles.OrderBy(x => x.Title))
                {
                    Console.WriteLine(article.ToString());
                }
            }
            else if(criteria == "content")
            {
                foreach (Article article in catalog.Articles.OrderBy(x => x.Content))
                {
                    Console.WriteLine(article.ToString());
                }
            }
            else
            {
                foreach (Article article in catalog.Articles.OrderBy(x => x.Author))
                {
                    Console.WriteLine(article.ToString());
                }
            }

            
            
        }
    }
}
