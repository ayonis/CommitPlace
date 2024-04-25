namespace CommitePlace.Models
{
    public class Student
    {
        public string Identification { get; set; }
        public string ArabicName { get; set; }
        public string Degree { get; set; }
        public string Center { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}