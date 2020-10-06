using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewAndViewModelExample.Web.Models;
using Wba.Oefening.Students.Domain;

namespace ViewAndViewModelExample.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentRepository _studentRepository;

        public StudentController()
        {

            _studentRepository = new StudentRepository();

        }



        [Route("Students/Index")]
        public IActionResult Index() 
        {
            var showStudentInfo = new StudentVM();
            showStudentInfo.students = _studentRepository.GetStudents();

            return View(showStudentInfo);
        }
    }
}
