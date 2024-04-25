using CommitePlace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CommitePlace.ViewModel;


namespace CommitePlace.Controllers
{
    public class StudentController : Controller
    {
        private readonly CommitDB _context;

        public StudentController(CommitDB context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetStudent(string studentId)
        {
            var student = await _context.Students.Include(s => s.StudentCourses)
                                                  .ThenInclude(sc => sc.Course)
                                                  .FirstOrDefaultAsync(s => s.Identification == studentId);

            if (student != null)
            {
                var viewModel = new StudentCourseViewModel
                {
                    StudentId = studentId,
                    ArabicName = student.ArabicName,
                    Degree = student.Degree,
                    Center = student.Center,
                    Courses = student.StudentCourses.Select(sc => new CourseViewModel
                    {
                        CourseId = sc.Course.CourseId,
                        CourseName = sc.Course.CourseName,
                        ExamTime = sc.Course.ExamTime,
                        Room = sc.Course.Room,
                        Place = sc.Course.Place
                    }).ToList()
                };

                return View(viewModel);
            }
            else
            {
                return View(new StudentCourseViewModel());
            }
        }
        
    }
}