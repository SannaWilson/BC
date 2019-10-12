using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyDB.Models;

namespace MyDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PakkausController : ControllerBase
    {
        public List<Pakkaus0> ListaaKaikki()
        {
            ImportContext konteksti = new ImportContext();
            List<Pakkaus0> kaikki = konteksti.Pakkaus0.ToList();
            return kaikki;
        }

      [HttpGet]
        [Route("{id}")]
        public Pakkaus0 ListaaYksi(int id)
        {
            ImportContext konteksti = new ImportContext();
            Pakkaus0 pakkaus = (from e in konteksti.Pakkaus0
                             where e.Pakkausnro == id
                             select e).FirstOrDefault();

            return pakkaus;
        }

 
    /* private readonly ImportContext _context;

 public PakkausController(ImportContext context)
 {
     _context = context;
 }

 // GET: api/Pakkaus
 [HttpGet]
public IEnumerable<Pakkaus0> GetPakkaus0()
 {
     return _context.Pakkaus0;
 }

 // GET: api/Pakkaus/5
 [HttpGet("{id}")]
 public async Task<IActionResult> GetPakkaus0([FromRoute] int id)
 {
     if (!ModelState.IsValid)
     {
         return BadRequest(ModelState);
     }

     var pakkaus0 = await _context.Pakkaus0.FindAsync(id);

     if (pakkaus0 == null)
     {
         return NotFound();
     }

     return Ok(pakkaus0);
 }

 // PUT: api/Pakkaus/5
 [HttpPut("{id}")]
 public async Task<IActionResult> PutPakkaus0([FromRoute] int id, [FromBody] Pakkaus0 pakkaus0)
 {
     if (!ModelState.IsValid)
     {
         return BadRequest(ModelState);
     }

     if (id != pakkaus0.Pakkausnro)
     {
         return BadRequest();
     }

     _context.Entry(pakkaus0).State = EntityState.Modified;

     try
     {
         await _context.SaveChangesAsync();
     }
     catch (DbUpdateConcurrencyException)
     {
         if (!Pakkaus0Exists(id))
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

 // POST: api/Pakkaus
 [HttpPost]
 public async Task<IActionResult> PostPakkaus0([FromBody] Pakkaus0 pakkaus0)
 {
     if (!ModelState.IsValid)
     {
         return BadRequest(ModelState);
     }

     _context.Pakkaus0.Add(pakkaus0);
     try
     {
         await _context.SaveChangesAsync();
     }
     catch (DbUpdateException)
     {
         if (Pakkaus0Exists(pakkaus0.Pakkausnro))
         {
             return new StatusCodeResult(StatusCodes.Status409Conflict);
         }
         else
         {
             throw;
         }
     }

     return CreatedAtAction("GetPakkaus0", new { id = pakkaus0.Pakkausnro }, pakkaus0);
 }

 // DELETE: api/Pakkaus/5
 [HttpDelete("{id}")]
 public async Task<IActionResult> DeletePakkaus0([FromRoute] int id)
 {
     if (!ModelState.IsValid)
     {
         return BadRequest(ModelState);
     }

     var pakkaus0 = await _context.Pakkaus0.FindAsync(id);
     if (pakkaus0 == null)
     {
         return NotFound();
     }

     _context.Pakkaus0.Remove(pakkaus0);
     await _context.SaveChangesAsync();

     return Ok(pakkaus0);
 }

 private bool Pakkaus0Exists(int id)
 {
     return _context.Pakkaus0.Any(e => e.Pakkausnro == id);
 }
    */
}
}