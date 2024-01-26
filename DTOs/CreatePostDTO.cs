using FundamentosEF_Blog.Models;
using System.Collections.Generic;

namespace FundamentosEF_Blog.DTOs
{
    public class CreatePostDTO
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public IList<Tag> Tags { get; set; }
    }
}
