

namespace CommitePlace.ViewModel
{
    public class StudentCourseViewModel
    {
        public string StudentId { get; set; }
        public string ArabicName { get; set; }
        public string Degree { get; set; }
        public string Center { get; set; }

        public List<CourseViewModel> Courses { get; set; }
    }
}