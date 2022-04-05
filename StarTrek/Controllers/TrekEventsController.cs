using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarTrek.Models;

namespace StarTrek.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TrekEventsController : ControllerBase
  {
    private readonly StarTrekContext _db;

    public TrekEventsController(StarTrekContext db)
    {
      _db = db;
    }

    // GET: api/Events
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TrekEvent>>> Get(string description, int date)
    {
      var query = _db.TrekEvents.AsQueryable();

      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }
      if (date != 0)
      {
        query = query.Where(entry => entry.Date >= date);
      }

      return await query.ToListAsync();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTrekEvent(int id)
    {
      var trekEvent = await _db.TrekEvents.FindAsync(id);
      if (trekEvent != null)
      {
        return NotFound();
      }
      _db.TrekEvents.Remove(trekEvent);
      await _db.SaveChangesAsync();
      return NoContent();
    }
    
    [HttpPost]
    public async Task<ActionResult<TrekEvent>> Post(TrekEvent trekEvent)
    {
      _db.TrekEvents.Add(trekEvent);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetTrekEvent), new { id = trekEvent.TrekEventId}, trekEvent);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<TrekEvent>> GetTrekEvent(int id)
    {
      var trekEvent = await _db.TrekEvents.FindAsync(id);
      if ( trekEvent == null )
      {
        return NotFound();
      }
      return trekEvent;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, TrekEvent trekEvent)
    {
      if (id != trekEvent.TrekEventId)
      {
        return BadRequest();
      }
      _db.Entry(trekEvent).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!TrekEventExists(id))
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
    private bool TrekEventExists(int id)
    {
      return _db.TrekEvents.Any(e => e.TrekEventId == id);
    }

  }
}