using Microsoft.EntityFrameworkCore;
using UniversityAPI.Models.DataModels;

namespace UniversityAPI.DataAcces
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) { 
        
        }

        //Add DbSets
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Student>?  Students { get; set; }  
    }
}
