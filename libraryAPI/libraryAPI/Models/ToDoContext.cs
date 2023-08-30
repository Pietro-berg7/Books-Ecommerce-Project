using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Models
{
    public class ToDoContext: DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> option)
            : base(option)
        {
            if (!todoProducts.Any())
            {
                todoProducts.AddRange(new[]
                {
                    new Product
                    {
                        Id = "1",
                        Name = "1984",
                        Price = 24.0,
                        Quantity = 1,
                        Category = "Dystopian",
                        Img = "img1"
                    },
                    new Product
                    {
                        Id = "2",
                        Name = "The Catcher in the Rye",
                        Price = 18.5,
                        Quantity = 3,
                        Category = "Classic",
                        Img = "img2"
                    },
                    new Product
                    {
                        Id = "3",
                        Name = "The Girl on the Train",
                        Price = 14.99,
                        Quantity = 6,
                        Category = "Mystery",
                        Img = "img3"
                    },
                    new Product
                    {
                        Id = "4",
                        Name = "The Hobbit",
                        Price = 22.0,
                        Quantity = 2,
                        Category = "Fantasy",
                        Img = "img4"
                    },
                    new Product
                    {
                        Id = "5",
                        Name = "Dune",
                        Price = 9.95,
                        Quantity = 8,
                        Category = "Science Fiction",
                        Img = "img5"
                    },
                    new Product
                    {
                        Id = "6",
                        Name = "Pride and Prejudice",
                        Price = 12.5,
                        Quantity = 5,
                        Category = "Romance",
                        Img = "img6"
                    }
                });

                SaveChanges();
            }
        }

        public DbSet<Product> todoProducts { get; set; }
    }
}
