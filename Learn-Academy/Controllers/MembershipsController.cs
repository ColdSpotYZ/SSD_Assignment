using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Learn_Academy.Models;

namespace Learn_Academy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipsController : ControllerBase
    {
        private readonly Learn_AcademyContext _context;


        public MembershipsController(Learn_AcademyContext context)
        {
            _context = context;
        }

        // GET: api/Memberships
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Membership>>> GetMembership()
        {
            return await _context.Membership.ToListAsync();
        }

        // GET: api/Memberships/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Membership>> GetMembership(string id)
        {
            var membership = await _context.Membership.FindAsync(id);

            if (membership == null)
            {
                return NotFound();
            }

            return membership;
        }

        // PUT: api/Memberships/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMembership(string id, Membership membership)
        {
            if (id != membership.PurchaseId)
            {
                return BadRequest();
            }

            _context.Entry(membership).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MembershipExists(id))
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

        // POST: api/Memberships
        [HttpPost]
        public async Task<ActionResult<Membership>> PostMembership(Membership membership)
        {
            _context.Membership.Add(membership);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMembership", new { id = membership.PurchaseId }, membership);
        }

        // DELETE: api/Memberships/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Membership>> DeleteMembership(string id)
        {
            var membership = await _context.Membership.FindAsync(id);
            if (membership == null)
            {
                return NotFound();
            }

            _context.Membership.Remove(membership);
            await _context.SaveChangesAsync();

            return membership;
        }

        private bool MembershipExists(string id)
        {
            return _context.Membership.Any(e => e.PurchaseId == id);
        }
    }
}
