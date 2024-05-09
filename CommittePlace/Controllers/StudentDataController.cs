using CommittePlace.Models;
using CommittePlace.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CommittePlace.Controllers
{
    public class StudentDataController : Controller
    {
        public IActionResult GetStudentData(string studentId)
        {
            CommiteeDB context = new CommiteeDB();
            List<StudentDataViewModel> studentData = context.GetStudentRoomsExams(studentId);

            return View("Index",studentData);
        }
    }
}
