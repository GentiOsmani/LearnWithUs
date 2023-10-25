namespace MenagmentSystem.Entities
{
    public class CourseDetails
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public double Price { get; set; }
        public TimeSpan Duration { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public string ThumbNail { get; set; }
        public Lecturers Lecturer { get; set; }
        public string LecturerId { get; set; }
        public int Attendences { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime ScheduleStart { get; set; }
        public DateTime ScheduleEnd { get; set; }
    }
}