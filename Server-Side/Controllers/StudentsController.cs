using firstRest.Models;
using firstRest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace firstRest.Controllers
{
	[Route("api/Students")]
	[ApiController]
	public class StudentsController : ControllerBase
	{
		private readonly StudentService studentService;

		public StudentsController(StudentService studentService)
		{
			this.studentService = studentService;
		}


		#region ActionResult vs IActionResult
		/*
		 * ActionResult<T> Provides Strong Typing
		 * ActionResult<IEnumerable<Student>> explicitly states that the response must contain a list of students.
		 * If IActionResult was used, the method could return anything (e.g., string, int, or JSON), making it less type-safe.
		 * 
		 * ActionResult<T> ✅	When the response must return a specific type (e.g., List<Student>).
		 *	IActionResult ✅	When the response can be different types (e.g., Ok(), NotFound(), BadRequest()).
		 */
		#endregion

		//   /api/students/passed → Get passed students
        //   /api/students/all → Get all students


		[HttpGet("all")]
		public ActionResult<IEnumerable<Student>> GetAllStudents()
		{
			IEnumerable<Student> students = studentService.GetAllStudents();
			
			if(students ==null || !students.Any())
			{
				return NotFound();
			}

			return Ok(students);
		}

		[HttpGet("passed")] // you can use Name to generate the url automatically
		public ActionResult<IEnumerable<Student>> GetPassedStudents()
		{
			Predicate<Student> predicate = std => std.Grade >= 50;

			IEnumerable<Student> students = studentService.GetAllStudents()
				.Where(std=>predicate(std)).ToList();

			if (students == null || !students.Any())
			{
				return NotFound();
			}

			return Ok(students);
		}

		[HttpGet("failed")] // you can use Name to generate the url automatically
		public ActionResult<IEnumerable<Student>> GetFailedStudents()
		{
			Predicate<Student> predicate = std => !(std.Grade >= 50);

			IEnumerable<Student> students = studentService.GetAllStudents()
				.Where(std => predicate(std)).ToList();

			if (students == null || !students.Any())
			{
				return NotFound();
			}

			return Ok(students);
		}
	}
}
