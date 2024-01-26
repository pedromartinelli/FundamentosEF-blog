using FundamentosEF_Blog.DTOs;
using System;
using System.Collections.Generic;

namespace FundamentosEF_Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int AuthorId { get; set; }
        public User Author { get; set; }

        public IList<Tag> Tags { get; set; }

        public static Post FromDTO(CreatePostDTO createPostDTO)
        {
            return new Post
            {
                Category = createPostDTO.Category,
                Title = createPostDTO.Title,
                Summary = createPostDTO.Summary,
                Body = createPostDTO.Body,
                Slug = createPostDTO.Slug,
                CategoryId = createPostDTO.CategoryId,
                AuthorId = createPostDTO.AuthorId,
                Tags = createPostDTO.Tags,
                CreateDate = DateTime.Now.ToUniversalTime(),
                LastUpdateDate = DateTime.Now.ToUniversalTime()
            };
        }
    }
}
