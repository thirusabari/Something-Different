using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CRUD.Model
{
	public class IDCardDetails
	{
		[Key]
		public int CardId { get; set; }
		public string Name { get; set; }
		public char Gender { get; set; }
		public string BloodGroup { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string Address3 { get; set; }
		public string City { get; set; }
		public string ZipCode { get; set; }
		public int PhoneNumber1 { get; set; }
		public int? PhoneNumber2 { get; set; }
		public bool IsEmployee { get; set; }
		public bool IsStudent { get; set; }
		public string CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
	}
}
