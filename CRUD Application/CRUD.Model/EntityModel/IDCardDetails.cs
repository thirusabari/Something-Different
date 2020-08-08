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
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string Address3 { get; set; }
		public string City { get; set; }
		public int PhoneNumber { get; set; }
		public string ZipCode { get; set; }
	}
}
