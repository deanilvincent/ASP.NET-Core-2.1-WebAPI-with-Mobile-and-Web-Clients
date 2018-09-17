using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoveTeamsController : ControllerBase
    {
        private readonly MyAppDbContext context;

        public LoveTeamsController(MyAppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await context.LoveTeams.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            return Ok(new
            {
                result = await context.LoveTeams.Where(x => x.LoveTeamId == id).FirstOrDefaultAsync()
            });
        }

        [HttpPost]
        public async Task<IActionResult> Create(LoveTeam student)
        {
            if (student == null) return BadRequest();

            try
            {
                context.LoveTeams.Add(student);
                await context.SaveChangesAsync();

                return Ok(new
                {
                    result = "Successfully saved"
                });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, LoveTeam student)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            if (student == null) return BadRequest();

            try
            {
                student.LoveTeamId = id;
                context.LoveTeams.Update(student);
                await context.SaveChangesAsync();

                return Ok(new
                {
                    result = "Successfully updated"
                });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0) return BadRequest();

            try
            {
                var student = await context.LoveTeams.Where(x => x.LoveTeamId == id).FirstOrDefaultAsync();
                context.LoveTeams.Remove(student);
                await context.SaveChangesAsync();

                return Ok(new
                {
                    result = "Successfully deleted"
                });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
