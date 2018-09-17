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
    public class StudentsController : ControllerBase
    {
        private readonly MyAppDbContext context;

        public StudentsController(MyAppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await context.Students.ToListAsync());
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
                result = await context.Students.Where(x => x.StudentId == id).FirstOrDefaultAsync()
            });
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (student == null) return BadRequest();

            try
            {
                context.Students.Add(student);
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
        public async Task<IActionResult> Edit(int id, Student student)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            if (student == null) return BadRequest();

            try
            {
                student.StudentId = id;
                context.Students.Update(student);
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
                var student = await context.Students.Where(x => x.StudentId == id).FirstOrDefaultAsync();
                context.Students.Remove(student);
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
