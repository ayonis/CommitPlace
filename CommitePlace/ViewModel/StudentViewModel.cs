using System.Collections.Generic;

namespace CommitePlace.ViewModel
{
    public class StudentViewModel
    {
        public string StudentId { get; set; }
        public string Identification { get; set; }
        public string ArabicName { get; set; }
        public string Degree { get; set; }
        public string Center { get; set; }
        public string Place { get; set; }
        public List<CourseViewModel> Courses { get; set; }
    }
}