using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Model
{
	public class RequestObject
	{
		public bool status { get; set; }
		public bool IsDbException { get; set; }
		public string ErrorMessage { get; set; }
	}
}
