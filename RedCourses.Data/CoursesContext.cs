using System.Data.Entity;
using RedCourses.Domain;

namespace RedCourses.Data
{
    public class CoursesContext : DbContext 
    {
        public DbSet<Course> Courses { get; set; }
    }
}
