using firstRest.Data;
using firstRest.Models;

namespace firstRest.Services
{
	public class StudentService : IStudentService
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

		public bool IsExists(Guid id)
		{
			return context.Students.Any(x => x.Id == id);
		}

		public Guid Add(Student student)
		{
			context.Students.Add(student);
			context.SaveChanges();
			return student.Id;
		}

		public void Delete(Student student)
		{
			context.Students.Remove(student);
			context.SaveChanges();
		}

		public Student? Update(Student updatedStudent)
		{
			Student? studentDB = context.Students.SingleOrDefault(std=>std.Id  == updatedStudent.Id);
			
			if (studentDB != null)
			{
				studentDB.Name = updatedStudent.Name;
				studentDB.Age = updatedStudent.Age;
				studentDB.Grade = updatedStudent.Grade;
				context.SaveChanges();

				return studentDB;
			}

			return null;
		}
	}
}
