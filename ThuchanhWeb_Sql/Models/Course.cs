using ThuchanhWeb_Sql.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThuchanhWeb_Sql.Models
{
	public class Course
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int CourseID { get; set; }
		public string Title { get; set; }
		public int Credits { get; set; }
		public ICollection<Enrollment> Enrollments { get; set; }
	}
}
