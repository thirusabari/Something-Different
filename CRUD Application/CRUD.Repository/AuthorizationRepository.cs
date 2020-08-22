using CRUD.Interface;
using CRUD.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUD.Repository
{
	public class AuthorizationRepository : IAuthorizationRepository
	{
		private CRUDContext CRUDContext;
		public LoginUI SignIn(LoginUI login)
		{
			var isUserExists = CRUDContext.UserLoginInfo.AsNoTracking()
				.Where(u => u.EmailId == login.EmailId).Any();
			// To DO
			// To Do Implemente
			return login;
		}
	}
}
