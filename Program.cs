using System;
using System.Linq;
using FundamentosEF_Blog.Data;
using FundamentosEF_Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace FundamentosEF_Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            //var user = new User
            //{
            //    Name = "Marcos Almeida",
            //    Slug = "marcosalmeida",
            //    Email = "malmeida@gmail.com",
            //    Bio = "Estagiário",
            //    Image = "https:marcosalmeida.io",
            //    PasswordHash = "123987456"
            //};

            //var category = new Category
            //{
            //    Name = "Backend",
            //    Slug = "backend-dotnet"
            //};

            //var post = new Post
            //{
            //    Author = user,
            //    Category = category,
            //    Body = "<p>Hello World</p>",
            //    Slug = "comecando-com-dotnet",
            //    Title = "Começando com .NET",   
            //    Summary = "Neste artigo vamos aprender .NET",
            //    CreateDate = DateTime.Now,
            //    LastUpdateDate = DateTime.Now
            //};

            //context.Posts.Add(post);
            //context.SaveChanges();


            //var post = context.Posts.FirstOrDefault(x => x.Id.Equals(2));
            //if (post != null)
            //{
            //    post.Title = "Começando com EF Core";
            //    context.Update(post);
            //}

            //context.SaveChanges();


            var posts = context.Posts.AsNoTracking().Include(x => x.Author)
                .OrderByDescending(x => x.LastUpdateDate).ToList();

            foreach (var post in posts)
            {
                Console.WriteLine($"\"{post.Title}\" escrito por {post.Author?.Name}");
            }
        }
    }
}
