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
		public ActionResult<IEnumerable<Student>> GetAll()
		{
			IEnumerable<Student> students = studentService.GetAll();
			
			if(students ==null || !students.Any())
			{
				return NotFound("No Students Found");
			}

			return Ok(students);
		}



		[HttpGet("passed")] // you can use Name to generate the url automatically
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public ActionResult<IEnumerable<Student>> GetPasseds()
		{
			Predicate<Student> predicate = std => std.Grade >= 50;

			IEnumerable<Student> students = studentService.GetAll()
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
		public ActionResult<IEnumerable<Student>> GetFaileds()
		{
			Predicate<Student> predicate = std => !(std.Grade >= 50);

			IEnumerable<Student> students = studentService.GetAll()
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
		public ActionResult<decimal> GetAverageGrades()
		{

			decimal average = studentService.GetAll().Average(std => std.Grade);
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
		public ActionResult<Student> GetById(Guid id) 
		{
			Student? student = studentService.GetById(id);

			if(student == null)
			{
				return NotFound(new { message = "Student not found" });
			}

			return Ok(student);
		}

		#region Notes
		// [FromBody] Attribute → Ensures JSON request body is correctly mapped to Student.
		//Request Body: Exclude the id(auto-generate) from the request body when creating a resource (let the server generate it).

		#endregion
		[HttpPost("add")]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]

		public ActionResult<Student> Add([FromBody]Student student)

		{
			if (!ModelState.IsValid)
			{
				// Return 400 Bad Request with validation errors
				return BadRequest(ModelState);
			}

			// save to db
			student.Id = studentService.Add(student);

			return CreatedAtAction(nameof(Add), new {id = student.Id},student);
		}
	}
}
