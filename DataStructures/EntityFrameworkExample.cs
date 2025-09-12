using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;



namespace dotnet_dsa.Codecademy;

public class Blog
{
    public int Id { get; set; }
    public string? Title { get; set; }
}

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=blogging.db");
}

class EntityFrameworkExample
{
    public static void Run()
    {
        using (var db = new BloggingContext())
        {
            db.Database.EnsureCreated();

            // Create
            Console.WriteLine("Inserting a new blog");
            db.Add(new Blog
            {
                Title = "Hello World"
            });
            db.SaveChanges();
            // Read
            Console.WriteLine("Querying for a blog");

            var firstBlog = db.Blogs
                .OrderBy(b => b.Id)
                .First();

            Console.WriteLine($"Blog found: {firstBlog.Title}");

            // Insert
            db.Blogs.Add(new Blog { Title = "EF Core Overview" });
            db.SaveChanges();

            // Query
            var blogs = db.Blogs
                .OrderBy(b => b.Id)
                .ToList();

            foreach (var blog in blogs)
                Console.WriteLine(blog.Title);
        }
    }
}
