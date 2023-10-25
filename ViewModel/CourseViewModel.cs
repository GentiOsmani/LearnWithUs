using MenagmentSystem.Entities;

namespace MenagmentSystem.ViewModel;
public class CourseViewModel
{
    public List<Course> Courses { get; set; }
    public int Id { get; set; }
    public string CourseName { get; set; }
    public string CourseDescription { get; set; }
    public int CourseTypeId { get; set; }
    public double CoursePrice {  get; set; }
    public int Members {  get; set; }
    public string Lecturer { get; set; }

    /*public CourseDetails CourseDetails { get; set; }*/
    public ICollection<CourseDetails> CourseDetails { get; set; }
}
