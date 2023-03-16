using JobManagementAPI.Data;
using JobManagementUI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly JobDbContext _context;
        public JobController(JobDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("AddJob")]
        public async Task<ActionResult<Job>> CreateJob(Job job)
        {
            if (_context.Jobs == null)
            {
                return Problem("Entity set 'DataContext.Inspections'  is null.");
            }
            job.scheduleDate = DateTime.Now;
            await _context.Jobs.AddAsync(job);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                Message = "Job Added Successfully!"
            });
           
        }

        [HttpGet]
        [Route("GetJobDetails")]
        public async Task<ActionResult<IEnumerable<Job>>> GetJobDetails()
        {
            if (_context.Jobs == null)
            {
                return NotFound();
            }
            var jobList = await _context.Jobs.ToListAsync();

            return Ok(jobList);
        }

        [HttpDelete("DeleteJob{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {

            var job = await _context.Jobs.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }

            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Deleted Successfully!" });
        }

    }
}
