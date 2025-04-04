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
        public List<Student> GetAll()
		{
			return context.Students.ToList();
		}

		public Student? GetById(Guid id)
		{
			return context.Students.SingleOrDefault(x => x.Id == id);
		}

		public Guid Add(Student student)
		{
			context.Students.Add(student);
			context.SaveChanges();
			return student.Id;
		}
	}
}
