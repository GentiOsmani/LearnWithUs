namespace MenagmentSystem.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseTypeId { get; set; }

        /*public CourseDetails CourseDetails { get; set; }*/
        public string CourseName { get; set; }
        public ICollection<CourseDetails> CourseDetails { get; set; }

    }
}
