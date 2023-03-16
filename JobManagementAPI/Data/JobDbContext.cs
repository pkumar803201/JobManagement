using JobManagementUI.Data;
using Microsoft.EntityFrameworkCore;

namespace JobManagementAPI.Data
{
    public class JobDbContext:DbContext
    {
        public JobDbContext(DbContextOptions<JobDbContext> options) : base(options)
        { }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<recipientEmail> recipientEmail { get; set; }
        public DbSet<url> Urls { get; set; }
    }
}
