using MenagmentSystem.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MenagmentSystem.Data;

public class MSDbContext : IdentityDbContext<User>
{
    public MSDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Lecturers> Lecturers { get; set;}
    public DbSet<CourseType> CourseTypes { get; set; }  
    public DbSet<CourseDetails> CoursesDetails { get; set;}
    public DbSet<Course> Courses { get; set;}
    public DbSet<Address> Addresses { get; set; }

}
