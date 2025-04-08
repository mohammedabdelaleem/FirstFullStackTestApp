using firstRest.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Text.Json;

namespace firstRest.Data
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        
        public DbSet<Student> Students { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			//// Seed Data : Only At Project Startup
			
			//string studentsJson = System.IO.File.ReadAllText("students.json");
			//List<Student> students = JsonSerializer.Deserialize<List<Student>>(studentsJson)!;
			//foreach (Student student in students)
			//{
			//	modelBuilder.Entity<Student>().HasData(student);
			//}

		}
	}
}
