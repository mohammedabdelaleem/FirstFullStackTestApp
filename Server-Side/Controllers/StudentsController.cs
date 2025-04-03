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


		//   http://localhost:5087/api/students/passed → Get passed students
		//   http://localhost:5087/api/students/all → Get all students


		[HttpGet("all")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public ActionResult<IEnumerable<Student>> GetAllStudents()
		{
			IEnumerable<Student> students = studentService.GetAllStudents();
			
			if(students ==null || !students.Any())
			{
				return NotFound("No Students Found");
			}

			return Ok(students);
		}



		[HttpGet("passed")] // you can use Name to generate the url automatically
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public ActionResult<IEnumerable<Student>> GetPassedStudents()
		{
			Predicate<Student> predicate = std => std.Grade >= 50;

			IEnumerable<Student> students = studentService.GetAllStudents()
				.Where(std=>predicate(std)).ToList();

			if (students == null || !students.Any())
			{
				return NotFound("No Students Passed");
			}

			return Ok(students);
		}


		[HttpGet("failed")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public ActionResult<IEnumerable<Student>> GetFailedStudents()
		{
			Predicate<Student> predicate = std => !(std.Grade >= 50);

			IEnumerable<Student> students = studentService.GetAllStudents()
				.Where(std => predicate(std)).ToList();

			if (students == null || !students.Any())
			{
				return NotFound("No Students Failed");
			}

			return Ok(students);
		}


		[HttpGet("average")] // you can use Name to generate the url automatically
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult<decimal> GetAverageStudentsGrade()
		{

			decimal average = studentService.GetAllStudents().Average(std => std.Grade);
			if(average <= 0)
			{
				return BadRequest("Average Can't Be 0 or Less");
			}
			decimal averageFormated = Math.Round(average, 2);
			return Ok(new {average = averageFormated });
		}


		[HttpGet("{id:guid}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public ActionResult<Student> GetStudentById(Guid id) 
		{
			Student? student = studentService.GetStudentById(id);

			if(student == null)
			{
				return NotFound(new { message = "Student not found" });
			}

			return Ok(student);
		}
	}
}
