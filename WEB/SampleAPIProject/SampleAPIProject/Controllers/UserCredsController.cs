using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleAPIProject;
using SampleAPIProject.Data;

namespace SampleAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCredsController : ControllerBase
    {
        private readonly SampleAPIProjectContext _context;

        public UserCredsController(SampleAPIProjectContext context)
        {
            _context = context;
        }

        // GET: api/UserCreds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserCred>>> GetUserCred()
        {
            return await _context.UserCred.ToListAsync();
        }

        // GET: api/UserCreds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserCred>> GetUserCred(int id)
        {
            var userCred = await _context.UserCred.FindAsync(id);

            if (userCred == null)
            {
                return NotFound();
            }

            return userCred;
        }

        // PUT: api/UserCreds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserCred(int id, UserCred userCred)
        {
            if (id != userCred.id)
            {
                return BadRequest();
            }

            _context.Entry(userCred).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserCredExists(id))
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

        // POST: api/UserCreds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserCred>> PostUserCred(UserCred userCred)
        {
            _context.UserCred.Add(userCred);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserCred", new { id = userCred.id }, userCred);
        }

        // DELETE: api/UserCreds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserCred(int id)
        {
            var userCred = await _context.UserCred.FindAsync(id);
            if (userCred == null)
            {
                return NotFound();
            }

            _context.UserCred.Remove(userCred);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserCredExists(int id)
        {
            return _context.UserCred.Any(e => e.id == id);
        }
    }
}
