using FundamentosEF_Blog.Data;

namespace FundamentosEF_Blog
{
    public class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            //var tag = new Tag
            //{
            //    Name = "ASP.NET",
            //    Slug = "aspnet"
            //};
            //context.Tags.Add(tag);

            //var tag2 = new Tag
            //{
            //    Name = ".NET",
            //    Slug = "dotnet"
            //};
            //context.Tags.Add(tag2);

            //var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
            //tag.Name = ".NET";
            //tag.Slug = "dotnet";
            //context.Update(tag);

            //var tag = context.Tags.FirstOrDefault(x => x.Id == 2);
            //context.Remove(tag);

            //var tags = context.Tags.AsNoTracking().ToList();

            //foreach (var tag in tags)
            //{
            //    Console.WriteLine(tag.Name);
            //}

            //var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 5);

            //if (tag == null)
            //{
            //    Console.WriteLine("Tag não encontrada");
            //}

            //Console.WriteLine(tag?.Name);

            //context.SaveChanges();
        }
    }
}
