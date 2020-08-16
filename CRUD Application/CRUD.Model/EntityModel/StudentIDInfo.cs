using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Model
{
	public class StudentIDInfo
	{
		[Key]
		public int StudentId { get; set; }
		public int CardId { get; set; }
		[ForeignKey("CardId")]
		public IDCardDetails IDCardDetails { get; set; }
		public string StudentName { get; set; }
		public string Grade { get; set; }
		public string SchoolName { get; set; }
		public string CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
	}
}
