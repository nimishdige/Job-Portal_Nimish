using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Models;
namespace OnlineJobPortal.Data
{
    public class ApplicatonDbContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }

        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Recruiter> Recruiters { get; set; }


    }
}
