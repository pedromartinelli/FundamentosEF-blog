using System;
using FundamentosEF_Blog.Data;
using FundamentosEF_Blog.Models;

namespace FundamentosEF_Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            var user = new User
            {
                Name = "Pedro Martinelli",
                Slug = "pedromartinelli",
                Email = "pmartinelli@gmail.com",
                Bio = "Estagiário",
                Image = "https://pedromartinelli.io",
                PasswordHash = "123987456"
            };

            var category = new Category
            {
                Name = "Backend",
                Slug = "backend"
            };

            var post = new Post
            {
                Author = user,
                Category = category,
                Body = "<p>Hello World</p>",
                Slug = "comecando-com-ef-core",
                Title = "Começando com EF Core ",   
                Summary = "Neste artigo vamos aprender EF core",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            };

            context.Posts.Add(post);

            context.SaveChanges();
        }
    }
}
