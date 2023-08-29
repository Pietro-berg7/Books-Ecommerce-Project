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
                        Name = "Book1",
                        Price = 24.0,
                        Quantity = 1,
                        Category = "Action",
                        Img = "img1"
                    },
                    new Product
                    {
                        Id = "2",
                        Name = "Book2",
                        Price = 18.5,
                        Quantity = 3,
                        Category = "Fiction",
                        Img = "img2"
                    },
                    new Product
                    {
                        Id = "3",
                        Name = "Book3",
                        Price = 14.99,
                        Quantity = 6,
                        Category = "Mystery",
                        Img = "img3"
                    },
                    new Product
                    {
                        Id = "4",
                        Name = "Book4",
                        Price = 22.0,
                        Quantity = 2,
                        Category = "Fantasy",
                        Img = "img4"
                    },
                    new Product
                    {
                        Id = "5",
                        Name = "Book5",
                        Price = 9.95,
                        Quantity = 8,
                        Category = "Science Fiction",
                        Img = "img5"
                    },
                    new Product
                    {
                        Id = "6",
                        Name = "Book6",
                        Price = 12.5,
                        Quantity = 5,
                        Category = "Romance",
                        Img = "img6"
                    },
                    new Product
                    {
                        Id = "7",
                        Name = "Book7",
                        Price = 27.99,
                        Quantity = 4,
                        Category = "Thriller",
                        Img = "img7"
                    },
                    new Product
                    {
                        Id = "8",
                        Name = "Book8",
                        Price = 16.75,
                        Quantity = 7,
                        Category = "Adventure",
                        Img = "img8"
                    },
                    new Product
                    {
                        Id = "9",
                        Name = "Book9",
                        Price = 10.0,
                        Quantity = 9,
                        Category = "Non-Fiction",
                        Img = "img9"
                    },
                    new Product
                    {
                        Id = "10",
                        Name = "Book10",
                        Price = 19.99,
                        Quantity = 1,
                        Category = "Historical Fiction",
                        Img = "img10"
                    }
                });

                SaveChanges();
            }
        }

        public DbSet<Product> todoProducts { get; set; }
    }
}
