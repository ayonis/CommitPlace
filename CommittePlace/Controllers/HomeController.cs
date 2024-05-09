using CommittePlace.Models;
using CommittePlace.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CommittePlace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<StudentDataViewModel> studentData = new List<StudentDataViewModel>
                                                    { new StudentDataViewModel(){
                                                        StudentId = "",
                                                        StudentArabicName = "",
                                                        StudentCenter = "",
                                                        StudentDegree="",
                                                        CourseId="",
                                                        CourseName = "",
                                                        ExamTime = "",
                                                        RoomId = "",
                                                        RoomPlace =""
                                                    } 
                                                };
            return View("Index", studentData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
