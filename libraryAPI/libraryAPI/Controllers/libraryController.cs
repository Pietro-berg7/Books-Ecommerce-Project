using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class libraryController: ControllerBase
    {
        private readonly ToDoContext _context;

        public libraryController(ToDoContext context)
        {
            _context = context;

            _context.todoProducts.Add(new Product
            {
                Id = "1",
                Name = "Book1",
                Price = 24.0,
                Quantity = 1,
                Category = "Action",
                Img = "img1"
            });
            _context.todoProducts.Add(new Product
            {
                Id = "2",
                Name = "Book2",
                Price = 18.5,
                Quantity = 3,
                Category = "Fiction",
                Img = "img2"
            });
            _context.todoProducts.Add(new Product
            {
                Id = "3",
                Name = "Book3",
                Price = 14.99,
                Quantity = 6,
                Category = "Mystery",
                Img = "img3"
            });
            _context.todoProducts.Add(new Product
            {
                Id = "4",
                Name = "Book4",
                Price = 22.0,
                Quantity = 2,
                Category = "Fantasy",
                Img = "img4"
            });
            _context.todoProducts.Add(new Product
            {
                Id = "5",
                Name = "Book5",
                Price = 9.95,
                Quantity = 8,
                Category = "Science Fiction",
                Img = "img5"
            });
            _context.todoProducts.Add(new Product
            {
                Id = "6",
                Name = "Book6",
                Price = 12.5,
                Quantity = 5,
                Category = "Romance",
                Img = "img6"
            });
            _context.todoProducts.Add(new Product
            {
                Id = "7",
                Name = "Book7",
                Price = 27.99,
                Quantity = 4,
                Category = "Thriller",
                Img = "img7"
            });
            _context.todoProducts.Add(new Product
            {
                Id = "8",
                Name = "Book8",
                Price = 16.75,
                Quantity = 7,
                Category = "Adventure",
                Img = "img8"
            });
            _context.todoProducts.Add(new Product
            {
                Id = "9",
                Name = "Book9",
                Price = 10.0,
                Quantity = 9,
                Category = "Non-Fiction",
                Img = "img9"
            });
            _context.todoProducts.Add(new Product
            {
                Id = "10",
                Name = "Book10",
                Price = 19.99,
                Quantity = 1,
                Category = "Historical Fiction",
                Img = "img10"
            });

            _context.SaveChanges();
        }
    }
}
