using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;
using P01_StudentSystem.P01_StudentSystem.Data.Models;
using P01_StudentSystem.P01_StudentSystem.Data.Models.Configuration;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {



        public DbSet<Student> Students { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Homework> Homeworks { get; set; }






        public StudentSystemContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        private const string ConnectionString =
            "Server=.;Database=StudentSystem;Integrated Security=true";



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new StudentConfiguration());


            modelBuilder.ApplyConfiguration(new CourseConfiguration());


            modelBuilder.ApplyConfiguration(new ResourceConfiguration());

            modelBuilder.ApplyConfiguration(new HomeworkConfiguration());

            modelBuilder.ApplyConfiguration(new StudentCourseConfiguration());

        }
    }
}