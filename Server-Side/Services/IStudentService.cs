using firstRest.Models;

namespace firstRest.Services;

public interface IStudentService
{
	List<Student> GetAll();
	Student? GetById(Guid id);

	public bool IsExists(Guid id);

	public Guid Add(Student student);

	void Delete(Student student);


	Student? Update(Student updatedStudent);

}
