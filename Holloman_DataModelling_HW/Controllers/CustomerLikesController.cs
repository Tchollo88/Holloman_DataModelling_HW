using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Holloman_DataModelling_HW.Data;
using Holloman_DataModelling_HW.Models;

namespace Holloman_DataModelling_HW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerLikesController : ControllerBase
    {
        private readonly DataModellingDb _context;

        public CustomerLikesController(DataModellingDb context)
        {
            _context = context;
        }

        // GET: api/CustomerLikes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerLikes>>> GetCustomerLikes()
        {
            return await _context.CustomerLikes.ToListAsync();
        }

        // GET: api/CustomerLikes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerLikes>> GetCustomerLikes(int id)
        {
            var customerLikes = await _context.CustomerLikes.FindAsync(id);

            if (customerLikes == null)
            {
                return NotFound();
            }

            return customerLikes;
        }

        // PUT: api/CustomerLikes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerLikes(int id, CustomerLikes customerLikes)
        {
            if (id != customerLikes.Id)
            {
                return BadRequest();
            }

            _context.Entry(customerLikes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerLikesExists(id))
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

        // POST: api/CustomerLikes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerLikes>> PostCustomerLikes(CustomerLikes customerLikes)
        {
            _context.CustomerLikes.Add(customerLikes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerLikes", new { id = customerLikes.Id }, customerLikes);
        }

        // DELETE: api/CustomerLikes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerLikes(int id)
        {
            var customerLikes = await _context.CustomerLikes.FindAsync(id);
            if (customerLikes == null)
            {
                return NotFound();
            }

            _context.CustomerLikes.Remove(customerLikes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerLikesExists(int id)
        {
            return _context.CustomerLikes.Any(e => e.Id == id);
        }
    }
}
