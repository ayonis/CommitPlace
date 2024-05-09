namespace CommittePlace.Models
{
    public class Room
    {
        public string Id { get; set; }
        public string Place { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }
    }
}
