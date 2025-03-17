using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Apisegundods.Data;
using Apisegundods.models;

namespace Apisegundods.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class alunoController : ControllerBase
    {
        private readonly ApisegundodsContext _context;

        public alunoController(ApisegundodsContext context)
        {
            _context = context;
        }

        // GET: api/aluno
        [HttpGet]
        public async Task<ActionResult<IEnumerable<alunos>>> Getalunos()
        {
            return await _context.alunos.ToListAsync();
        }

        // GET: api/aluno/5
        [HttpGet("{id}")]
        public async Task<ActionResult<alunos>> Getalunos(int id)
        {
            var alunos = await _context.alunos.FindAsync(id);

            if (alunos == null)
            {
                return NotFound();
            }

            return alunos;
        }

        // PUT: api/aluno/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putalunos(int id, alunos alunos)
        {
            if (id != alunos.id)
            {
                return BadRequest();
            }

            _context.Entry(alunos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!alunosExists(id))
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

        // POST: api/aluno
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<alunos>> Postalunos(alunos alunos)
        {
            _context.alunos.Add(alunos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getalunos", new { id = alunos.id }, alunos);
        }

        // DELETE: api/aluno/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletealunos(int id)
        {
            var alunos = await _context.alunos.FindAsync(id);
            if (alunos == null)
            {
                return NotFound();
            }

            _context.alunos.Remove(alunos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool alunosExists(int id)
        {
            return _context.alunos.Any(e => e.id == id);
        }
    }
}
