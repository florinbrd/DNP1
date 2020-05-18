using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using WebApplication1.Data.Entities;
using WebApplication1.Data.Entities.Context;
using WebApplication1.Data.Repositories;

namespace WebApplication1.Controllers
{
    [Route("cats")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private readonly CatContext _context;
       

        public CatsController(CatContext context)
        {
            _context = context;
        }

        // GET: api/Cats
        [HttpGet("getall")]
        public async Task<ActionResult<IEnumerable<Cat>>> GetCats()
        {
            return await _context.Cats.ToListAsync();
        }
        
        // GET: api/Cats
        [HttpGet("getsold")]
        public async Task<ActionResult<IEnumerable<Cat>>> getsoldcats()
        {
            return await _context.Cats.Where(cat => !cat.orderNumber.Equals(0)).ToListAsync();
        }
        
        
      

        // GET: api/Cats/5
        [HttpGet("getone/{id}")]
        public async Task<ActionResult<Cat>> GetCat(int id)
        {
            var cat = await _context.Cats.FindAsync(id);

            if (cat == null)
            {
                return NotFound();
            }

            return cat;
        }
        
        
        // GET: api/Cats/5
        [HttpGet("ordercat/{catId},{orderId}")]
        public async Task<ActionResult<Cat>> orderCat(int catId, int orderId )
        {
            Cat cat = _context.Cats.FirstOrDefault(cat => cat.id == catId);
            Order order = _context.Orders.FirstOrDefault(order => order.id == orderId);
            cat.orderNumber = orderId; 
            
            order.Cats = new List<Cat>();
            order.Cats.Add(cat);

            _context.SaveChangesAsync();




            if (cat == null)
            {
                return NotFound();
            }

            return cat;
        }

       

        // POST: api/Cats
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cat>> PostCat(Cat cat)
        {
            _context.Cats.Add(cat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCat", new { id = cat.id }, cat);
        }

        // DELETE: api/Cats/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cat>> DeleteCat(int id)
        {
            var cat = await _context.Cats.FindAsync(id);
            if (cat == null)
            {
                return NotFound();
            }

            _context.Cats.Remove(cat);
            await _context.SaveChangesAsync();

            return cat;
        }

        private bool CatExists(int id)
        {
            return _context.Cats.Any(e => e.id == id);
        }
    }
}
