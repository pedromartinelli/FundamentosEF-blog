using FundamentosEF_Blog.Data;
using FundamentosEF_Blog.DTOs;
using FundamentosEF_Blog.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FundamentosEF_Blog
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new BlogDataContext();

            var tag1 = new Tag
            {
                Name = "Backend",
                Slug = "backend-tag"
            };

            var tag2 = new Tag
            {
                Name = "Dotnet",
                Slug = "dotnet-tag"
            };

            List<Tag> tags = new List<Tag>() { tag1, tag2 };

            var createPostDTO = new CreatePostDTO
            {
                Title = "Fundamentos do .NET",
                Body = "...",
                Summary = "...",
                Slug = "fundamentos-C#",
                Tags = tags,
                CategoryId = 1,
                AuthorId = 1,
            };

            var result = await CreatePost(createPostDTO);

            if (result)
            {
                Console.WriteLine("{\n \"Success\": true,\n \"Message\": \"Post criado com sucesso.\" \n} ");
            }
            else
            {
                Console.WriteLine("{\n \"Success\": false,\n \"Message\": \"Não foi possível criar o Post.\" \n}");
            }
        }

        //public static async Task<IEnumerable<Post>> GetPosts()
        //{

        //}

        public static async Task<bool> CreatePost(CreatePostDTO createPostDTO)
        {
            using var context = new BlogDataContext();
            var createdPost = Post.FromDTO(createPostDTO);

            try
            {
                await context.Posts.AddAsync(createdPost);
                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
