using dotnet_crud_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_crud_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        /*private StudentService _studentService;

        public StudentsController()
        {
            _studentService = new StudentService();
        }*/

        [HttpGet]
        public IActionResult GetStudents()
        {
            /*var students = _studentService.AllStudents();*/
            var students = AllStudents();
            return Ok(students);
        }

        private List<Student> AllStudents()
        {
            var students = new List<Student>();

            var student1 = new Student
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "doe@gmail.com",
                Phone = "123-456-7890",
                City = "New York",
                CreatedAt = DateTime.Now
            };
            students.Add(student1);

            var student2 = new Student
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Email = "ddddd",
                Phone = "123-456-7890",
                City = "New York",
                CreatedAt = DateTime.Now
            };
            students.Add(student2);

            var student3 = new Student
            {
                Id = 3,
                FirstName = "Jane",
                LastName = "Doe",
                Email = "ddddd",
                Phone = "123-456-7890",
                City = "New York",
                CreatedAt = DateTime.Now
            };
            students.Add(student3);

            var student4 = new Student
            {
                Id = 4,
                FirstName = "Jane",
                LastName = "Doe",
                Email = "ddddd",
                Phone = "123-456-7890",
                City = "New York",
                CreatedAt = DateTime.Now
            };
            students.Add(student4);

            return students;
        }
    }
}
