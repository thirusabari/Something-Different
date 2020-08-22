using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CRUD.Model
{
	public class UserLoginInfo
	{
		[Key]
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string EmailId { get; set; }
		public string Password { get; set; }
		public DateTime LogInTime { get; set; }
		public DateTime? LogOutTime { get; set; }
		public string CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
	}
}
