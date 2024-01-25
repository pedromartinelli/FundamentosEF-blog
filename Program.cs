using FundamentosEF_Blog.Data;

namespace FundamentosEF_Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            //var user = new User
            //{
            //    Name = "Pedro Martinelli",
            //    Slug = "pedromartinelli",
            //    Email = "pmartinelli@gmail.com",
            //    Bio = "Estagiário",
            //    Image = "https:pedromartinelli.io",
            //    PasswordHash = "123987456"
            //};

            //var category = new Category
            //{
            //    Name = "Backend",
            //    Slug = "backend-entity-framework"
            //};

            //var user = context.Users.FirstOrDefault(x => x.Id.Equals(2));

            //var post = new Post
            //{
            //    Author = user,
            //    Category = new Category
            //    {
            //        Name = "Teste",
            //        Slug = "teste"
            //    },
            //    Body = "<p>Hello World</p>",
            //    Slug = "meu-artigo",
            //    Title = "Meu artigo",
            //    Summary = "Neste artigo vamos conferir...",
            //    Tags = new Tag[]
            //    {
            //        new Tag
            //        {
            //            Name = "Tag1",
            //            Slug = "tag1"
            //        },
            //        new Tag
            //        {
            //            Name = "Tag2",
            //            Slug = "tag2"
            //        }
            //    }
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

            //var posts = context.Posts
            //    .AsNoTracking()
            //    .Include(x => x.Author)
            //    .Include(x => x.Category)
            //    .OrderByDescending(x => x.LastUpdateDate)
            //    .ToList();

            //posts.Author.Name = "Teste";
            //context.Posts.Update(posts);
            //context.SaveChanges();

            //foreach (var post in posts)
            //{
            //    Console.WriteLine($"\"{post.Title}\" escrito por {post.Author?.Name} em {post.Category.Name}");
            //}
        }
    }
}
