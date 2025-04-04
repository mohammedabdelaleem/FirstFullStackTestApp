using System.ComponentModel.DataAnnotations;

namespace firstRest.Models
{
	public class Student
	{
		[Key]
        public Guid Id { get; set; }

		[Required(ErrorMessage = "Name is required.")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "Name length must between 2 and 100 characters.")]
		public string Name { get; set; }


		[Required(ErrorMessage = "Age is required.")]
		[Range(15, 60,ErrorMessage = "Age must between 15 and 60 years")]
		public int Age { get; set; }


		[Required(ErrorMessage = "Grade is required.")]
		[Range(0, 100, ErrorMessage = "Grade must between 0 and 100 years")]
		public decimal Grade { get; set; }


	}
}
