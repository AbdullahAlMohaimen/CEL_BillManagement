using System.ComponentModel.DataAnnotations;

namespace CEL_BillManagement.Models
{
	public class Project
	{
		[Key]
		public int ProjectID { get; set; }

		[Required]
		[DataType(DataType.Text)]
		public string ProjectNo { get; set; }

		[Required]
		[DataType(DataType.Text)]
		[StringLength(200)]
		public string ProjectName { get; set; }

		[Required]
		[DataType(DataType.Text)]
		[StringLength(255)]
		public string ProjectDescription { get; set; }

		[Required]
		public float ProjectCost { get; set; }
	}
}
