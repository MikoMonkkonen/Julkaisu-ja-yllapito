using Microsoft.EntityFrameworkCore;
using StudentManagement;
namespace StudentManagement
{
	public class StudentContext : DbContext
	{
		public StudentContext(DbContextOptions<StudentContext> options) : base(options){ }

		public DbSet<Student> Students { get; set; } = null!;
	}
}