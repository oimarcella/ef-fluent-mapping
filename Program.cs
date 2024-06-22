using System;
using System.Linq;
using Blog.Data;
using Blog.Models;

namespace Blog;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vamos estudar EF e Fluent Mapping!");

        using var ctx = new BlogDataContext();
        /**/ctx.Users.Add(new User{
            Name = "Fulano de Tal",
            Email = "fulano@tal.com.br",
            Image = "muimg.png",
            Bio = "Muito falado por aí",
            Slug = "otalfulano",
            PasswordHash = "123abc",
            GitHub = "oimarcella"
        });

        /*var user = ctx.Users.FirstOrDefault(x=> x.Id == 1011);
        ctx.Posts.Add(new Post {
            Title = "Como começar no ecossistema .NET",
            Body = "Meu artigo",
            Category = new Category {
                Name = "UI",
                Slug = "user-interface"
            },
            Author = user,
            CreateDate = DateTime.Now,
            Slug = "comecando-no-dotnet",
            Summary = "Ola dev",
            //Tags = null
        });*/

        ctx.SaveChanges();
    }
}
