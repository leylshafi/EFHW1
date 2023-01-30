using EFHW1.Contexts;
using EFHW1.Enums;
using EFHW1.Models;

namespace EFHW1;

public class Program
{
    static void Main()
    {
        var context = new LibraryDbContext();

        context.Types.AddRange
            (
            new BookType()
            {
                Name = "Adventure",
            },
            new BookType()
            {
                Name = "IT"
            },
            new BookType()
            {
                Name = "Mathematics"
            }
            );

        context.SaveChanges();


        context.Books.AddRange
            (
            new Book()
            {
                Name = "Anne of GreenGables",
                BookTypeId = 1,
                PageCount = Random.Shared.Next(1000),
            },
            new Book()
            {
                Name = "C# .NET",
                BookTypeId = 2,
                PageCount = Random.Shared.Next(1000),
                Status = DataStatus.Updated
            },
            new Book()
            {
                Name = "Trigonometry",
                BookTypeId = 3,
                PageCount = Random.Shared.Next(1000),
                Status = DataStatus.Deleted
            }
            );


        context.SaveChanges();

        var list = context.Books.Select(b => new
        {
            b.Id,
            b.Name,
            b.PageCount,
            b.BookTypeId,
            b.Status
        });


        foreach (var book in list)
        {
            Console.WriteLine(@$"{book.Id}) {book.Name}
{book.PageCount}
{book.BookTypeId}
{book.Status}
");
        }
    }
}

