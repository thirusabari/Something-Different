using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Model
{
	public class EmployeeIDInfo
	{
		[Key]
		public int EmpId { get; set; }
		public int CardId { get; set; }
		[ForeignKey("CardId")]
		public IDCardDetails IDCardDetails { get; set; }
		public string EmployeeName { get; set; }
		public string EmployeeCode { get; set; }
		public string CompanyName { get; set; }
		public string CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
	}
}
