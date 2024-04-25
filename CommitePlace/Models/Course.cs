namespace CommitePlace.Models
{
    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public string ExamTime { get; set; }
        public string Room { get; set; }
        public string Place { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }

    }
}