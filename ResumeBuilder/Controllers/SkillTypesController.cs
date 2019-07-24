using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Models;

namespace ResumeBuilder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillTypesController : ControllerBase
    {
        private readonly ResumeBuilderContext _context;

        public SkillTypesController(ResumeBuilderContext context)
        {
            _context = context;
        }

        // GET: api/SkillTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillType>>> GetSkillType()
        {
            return await _context.SkillType.ToListAsync();
        }

        // GET: api/SkillTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillType>> GetSkillType(int id)
        {
            var skillType = await _context.SkillType.FindAsync(id);

            if (skillType == null)
            {
                return NotFound();
            }

            return skillType;
        }

        // PUT: api/SkillTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkillType(int id, SkillType skillType)
        {
            if (id != skillType.Id)
            {
                return BadRequest();
            }

            _context.Entry(skillType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillTypeExists(id))
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

        // POST: api/SkillTypes
        [HttpPost]
        public async Task<ActionResult<SkillType>> PostSkillType(SkillType skillType)
        {
            _context.SkillType.Add(skillType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSkillType", new { id = skillType.Id }, skillType);
        }

        // DELETE: api/SkillTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SkillType>> DeleteSkillType(int id)
        {
            var skillType = await _context.SkillType.FindAsync(id);
            if (skillType == null)
            {
                return NotFound();
            }

            _context.SkillType.Remove(skillType);
            await _context.SaveChangesAsync();

            return skillType;
        }

        private bool SkillTypeExists(int id)
        {
            return _context.SkillType.Any(e => e.Id == id);
        }
    }
}
