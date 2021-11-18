﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YouHungry.Models;

namespace YouHungry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratosController : ControllerBase
    {
        private readonly Context _context;

        public PratosController(Context context)
        {
            _context = context;
        }

        // GET: api/Pratoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prato>>> GetPratos()
        {
            return await _context.Pratos.Include("Restaurante").ToListAsync();
        }

        // GET: api/Pratoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prato>> GetPrato(int id)
        {
            var prato = await _context.Pratos.FindAsync(id);

            if (prato == null)
            {
                return NotFound();
            }

            return prato;
        }

        // PUT: api/Pratoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrato(int id, Prato prato)
        {
            if (id != prato.Id)
            {
                return BadRequest();
            }

            _context.Entry(prato).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PratoExists(id))
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

        // POST: api/Pratoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Prato>> PostPrato(Prato prato)
        {
            _context.Pratos.Add(prato);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrato", new { id = prato.Id }, prato);
        }

        // DELETE: api/Pratoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrato(int id)
        {
            var prato = await _context.Pratos.FindAsync(id);
            if (prato == null)
            {
                return NotFound();
            }

            _context.Pratos.Remove(prato);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PratoExists(int id)
        {
            return _context.Pratos.Any(e => e.Id == id);
        }
    }
}
