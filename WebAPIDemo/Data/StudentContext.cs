using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Entities;

namespace WebAPIDemo.Data
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
