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
  public class CharactersController : ControllerBase
  {
    private readonly StarTrekContext _db;

    public CharactersController(StarTrekContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Character>>> Get(string name)
    {
      var query = _db.Characters.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      

      return await query.ToListAsync();
    }

    private bool CharacterExists(int id)
    {
      return _db.Characters.Any(e => e.CharacterId == id);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Character character)
    {
      if (id != character.CharacterId)
      {
        return BadRequest();
      }
      _db.Entry(character).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CharacterExists(id))
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

    [HttpPost]
    public async Task<ActionResult<Character>> Post(Character character)
    {
      _db.Characters.Add(character);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(Character), new { id = character.CharacterId}, character);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Character>> GetCharacter(int id)
    {
      var character = await _db.Characters.FindAsync(id);
      if ( character == null )
      {
        return NotFound();
      }
      return character;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCharacter(int id)
    {
      var character = await _db.Characters.FindAsync(id);
      if (character != null)
      {
        return NotFound();
      }
      _db.Characters.Remove(character);
      await _db.SaveChangesAsync();
      return NoContent();
    }
  }
}