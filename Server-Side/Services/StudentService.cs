using firstRest.Data;
using firstRest.Models;

namespace firstRest.Services
{
	public class StudentService
	{
		private readonly AppDbContext context;

		public StudentService(AppDbContext context)
        {
			this.context = context;
		}
        public List<Student> GetAllStudents()
		{
			return context.Students.ToList();
		}
	}
}
