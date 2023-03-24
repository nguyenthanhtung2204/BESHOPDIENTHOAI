using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BESHOPDIENTHOAI.Models;

namespace BESHOPDIENTHOAI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailOdersController : ControllerBase
    {
        private readonly ShopDienThoaiContext _context;

        public DetailOdersController(ShopDienThoaiContext context)
        {
            _context = context;
        }

        // GET: api/DetailOders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetailOder>>> GetDetailOders()
        {
          if (_context.DetailOders == null)
          {
              return NotFound();
          }
            return await _context.DetailOders.ToListAsync();
        }

        // GET: api/DetailOders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetailOder>> GetDetailOder(int id)
        {
          if (_context.DetailOders == null)
          {
              return NotFound();
          }
            var detailOder = await _context.DetailOders.FindAsync(id);

            if (detailOder == null)
            {
                return NotFound();
            }

            return detailOder;
        }

        // PUT: api/DetailOders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetailOder(int id, DetailOder detailOder)
        {
            if (id != detailOder.Id)
            {
                return BadRequest();
            }

            _context.Entry(detailOder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetailOderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DetailOders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetailOder>> PostDetailOder(DetailOder detailOder)
        {
          if (_context.DetailOders == null)
          {
              return Problem("Entity set 'ShopDienThoaiContext.DetailOders'  is null.");
          }
            _context.DetailOders.Add(detailOder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetailOder", new { id = detailOder.Id }, detailOder);
        }

        // DELETE: api/DetailOders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetailOder(int id)
        {
            if (_context.DetailOders == null)
            {
                return NotFound();
            }
            var detailOder = await _context.DetailOders.FindAsync(id);
            if (detailOder == null)
            {
                return NotFound();
            }

            _context.DetailOders.Remove(detailOder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetailOderExists(int id)
        {
            return (_context.DetailOders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
