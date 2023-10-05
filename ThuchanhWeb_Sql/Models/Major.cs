

namespace ThuchanhWeb_Sql.Models
{
	public class Major 
	{
		public int MajorID { get; set; }
		public string MajorName { get; set; }
		public ICollection<Learner> Learners { get; set; }
	}
}
