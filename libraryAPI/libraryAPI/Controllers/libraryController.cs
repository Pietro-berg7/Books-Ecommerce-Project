using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController: ControllerBase
    {
        private readonly ToDoContext _context;

        public LibraryController(ToDoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.todoProducts.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetItem(int id)
        {
            var item = await _context.todoProducts.FindAsync(id.ToString());

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.todoProducts.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetItem), new { id = product.Id }, product);
        }
    }
}
