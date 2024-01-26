using FundamentosEF_Blog.Data;
using FundamentosEF_Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FundamentosEF_Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            //for (var i = 0; i <= 10; i++)
            //{
            //    var category = new Category
            //    {
            //        Name = $"Categoria {i}",
            //        Slug = $"categoria-{i}"
            //    };

            //    context.Categories.Add(category);
            //}
            //context.SaveChanges();


            var categories = GetCategories(context, 3, 6);

            foreach (var category in categories)
            {
                Console.WriteLine(category.Name);
            }
        }

        public static List<Category> GetCategories(BlogDataContext context, int skip, int take)
        {
            var categories = context
                .Categories
                .AsNoTracking()
                .Skip(skip)
                .Take(take)
                .ToList();
            return categories;
        }
    }
}
