using System.Collections.Generic;

namespace MenagmentSystem.Entities
{
    public class Lecturers
    {
        public Lecturers()
        {
            Courses = new HashSet<Course>();
        }
        public string Id { get; set; }
        public string? UserId { get; set; }
        public double Salary { get; set; }

        public User User { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
